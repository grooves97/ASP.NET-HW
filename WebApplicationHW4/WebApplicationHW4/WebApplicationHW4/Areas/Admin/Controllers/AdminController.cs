using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW4.DataAccess;
using WebApplicationHW4.Models;

namespace WebApplicationHW4.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddArticle(Article response)
        {
            using (var context = new Context())
            {
                if (response.Text == null)
                {
                    return Json(context.Articles.ToList(), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    var article = new Article
                    {
                        Title = response.Title,
                        Text = response.Text,
                        ImagePath = response.ImagePath
                    };

                    context.Articles.Add(article);
                    context.SaveChanges();

                    return Json(context.Articles.ToList(), JsonRequestBehavior.AllowGet);
                }
            }
        }
    }
}