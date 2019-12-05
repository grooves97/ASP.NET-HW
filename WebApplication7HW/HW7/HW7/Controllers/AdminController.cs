using HW7.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            using (var context = new UserContext())
            {
                var admin = context.Admins.FirstOrDefault(user => user.Login == login && user.Password == password);

                if (admin != null)
                {
                    return RedirectToAction("Index", "Articles");
                }
                else
                {
                    ViewBag.Message = "Данные введены не правильно";
                    return View();
                }
            }

        }
    }
}