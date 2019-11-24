using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.DataAccess;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        private ShopContext context = new ShopContext();
        // GET: Home
        public ActionResult Index()
        {
            var posts = context.Products.ToList();
            ViewData["Products"] = posts;

            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(Guid id)
        {
            Product product = context.Products.Find(id);
            ViewData["Product"] = product;

            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(string name, string description, int price)
        {
            context.Products.Add(new Product { Name=name, Description=description, Price = price });
            context.SaveChanges();
            var js = "window.location = '" + Url.Action("Index", "Home") + "' ;";

            return JavaScript(js);
        }

        public ActionResult Delete(Guid id)
        {
            Product product = context.Products.Find(id);
            context.Products.Remove(product);
            context.SaveChanges();
            ViewData["Product"] = product;

            return RedirectToAction("Index");
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
