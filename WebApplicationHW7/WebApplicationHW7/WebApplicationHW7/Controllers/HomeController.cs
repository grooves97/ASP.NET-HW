using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW7.DataAccess;
using WebApplicationHW7.Models;
using WebApplicationHW7.Provider;
using WebApplicationHW7.ViewModel;

namespace WebApplicationHW7.Controllers
{
    public class HomeController : Controller
    {
        CustomRoleProvider customRoleProvider = new CustomRoleProvider();
        private UserContext context = new UserContext();

        public ActionResult Index()
        {
            List<PostViewModel> viewModel = new List<PostViewModel>();
            if (User.Identity.IsAuthenticated)
            {
                List<Post> posts = new List<Post>();
                posts = context.Posts.ToList();

                foreach (var post in posts)
                {
                    viewModel.Add(new PostViewModel { ImgPath = post.ImgPath, Text = post.Text, Title = post.Title });
                }


                ViewData["Posts"] = viewModel;

                ViewData["IsAuthenticated"] = "Authenticated";

                if (customRoleProvider.IsUserInRole(User.Identity.Name, "admin"))
                {
                    ViewData["IsAdmin"] = "Admin";
                }
                else
                {
                    ViewData["IsAdmin"] = "NotAdmin";
                }
            }
            else
            {
                ViewData["IsAuthenticated"] = "NotAuthenticated";
                ViewData["IsAdmin"] = "NotAdmin";
            }


            return View(viewModel);
        }

        [Authorize(Roles = "admin")]
        public ActionResult Adminka()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewData["IsAuthenticated"] = "Authenticated";
                if (customRoleProvider.IsUserInRole(User.Identity.Name, "admin"))
                {
                    ViewData["IsAdmin"] = "Admin";
                }
                else
                {
                    ViewData["IsAdmin"] = "NotAdmin";
                }
            }
            else
            {
                ViewData["IsAuthenticated"] = "NotAuthenticated";
                ViewData["IsAdmin"] = "NotAdmin";
            }

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}