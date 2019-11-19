using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW4.DataAccess;

namespace WebApplicationHW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new Context())
            {
                ViewBag.News = context.Articles.ToList();
            }

            return View();
        }

    }
}