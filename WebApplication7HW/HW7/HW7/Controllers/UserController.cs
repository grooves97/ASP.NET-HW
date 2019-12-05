using HW7.DataAccess;
using HW7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
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

                    return RedirectToAction("AllNews");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
        }

        public ActionResult Auth()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Auth(string login, string password)
        {
            using (var context = new UserContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    return RedirectToAction("AllNews");
                }
                else
                {
                    ViewBag.message = "Данные введены не правильно";
                    return View();
                }
            }
        }

        public ActionResult AllNews()
        {
            using (var context = new UserContext())
            {
                ViewBag.News = context.Articles.ToList();
                return View();
            }
            
        }
    }
}