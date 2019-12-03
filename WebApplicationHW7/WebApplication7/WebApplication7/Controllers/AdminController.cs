using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.DataAccess;

namespace WebApplication7.Controllers
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
                var admin = context.UserAdmins.FirstOrDefault(user => user.Login == login && user.Password == password);

                if (admin != null)
                {
                    return RedirectToAction("Index", "Post");
                }
                else
                {
                    ViewData["Message"] = "Данные не совпали, повторите ввод!";
                    return View();
                }
            }
        }
    }
}