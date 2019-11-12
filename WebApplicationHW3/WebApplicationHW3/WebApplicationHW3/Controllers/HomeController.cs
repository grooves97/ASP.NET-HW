using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationHW3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string id)
        {
            return File($@"C:\Users\ww\Documents\GitHub\ASP.NET-HW\WebApplicationHW3\WebApplicationHW3\WebApplicationHW3\audio\{id}.mp3", "audio/mpeg", $"{id}.mp3");
        }

        public ActionResult All()
        {
            return File($@"C:\Users\ww\Documents\GitHub\ASP.NET-HW\WebApplicationHW3\WebApplicationHW3\WebApplicationHW3\audio\All.rar", "application/zip", $"album.zip");
        }
    }
}