using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DataAccess;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string login, string password, string phoneNumber)
        {
            using (var context = new UserContext())
            {
                if (login != null && password != null && phoneNumber != null)
                {
                    var user = new User
                    {
                        Login = login,
                        Password = password,
                        PhoneNumber = phoneNumber
                    };

                    context.Users.Add(user);
                    context.SaveChanges();

                    return RedirectToAction("News feed");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        public ActionResult Authorize()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(string login, string password)
        {
            using (var context = new UserContext())
            {
                var admin = context.UserAdmins.FirstOrDefault(user => user.Login == login && user.Password == password);

                if (admin != null)
                {
                    return RedirectToAction("News feed");
                }
                else
                {
                    ViewData["Message"] = "Данные не совпали, повторите ввод!";
                    return View();
                }
            }
        }

        public ActionResult AllPosts()
        {
            using (var context = new UserContext())
            {
                ViewBag.News = context.Posts.ToList();
                return View();
            }
        }
    }
}