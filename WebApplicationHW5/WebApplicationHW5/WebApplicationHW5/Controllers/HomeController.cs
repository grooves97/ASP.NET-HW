using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW5.DataAcces;
using WebApplicationHW5.Models;

namespace WebApplicationHW5.Controllers
{
    public class HomeController : Controller
    {
        WallContext context = new WallContext();
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new WallContext())
            {
                var messages = context.Messages.ToList();

                ViewData["Messages"] = messages;
            }
                return View();
        }

        [HttpPost]
        public ActionResult ProcessData(string name, string text)
        {
            context.Messages.Add(new Message { Name = name, Text = text });
            context.SaveChanges();
            return Json(new Message { Name = name, Text = text }, JsonRequestBehavior.AllowGet);
        }
    }
}