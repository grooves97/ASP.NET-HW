using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.DataAccess;
using WebApplication4.Models;

namespace WebApplication4.Areas.Admin.Controllers
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
                if ()
                {

                }
            }
        }
    }
}