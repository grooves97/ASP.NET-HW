using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationHW7.DataAccess;
using WebApplicationHW7.Models;

namespace WebApplicationHW7.Controllers
{
    [Authorize(Roles = "admin")]
    public class UsersController : Controller
    {
        private UserContext context = new UserContext();

        public ActionResult Index()
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            var users = context.Users.Include(u => u.RoleName);
            return View(users.ToList());
        }

        public ActionResult Details(int? id)
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            ViewBag.RoleId = new SelectList(context.Roles, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Password,Age,AboutMe,RoleId")] User user)
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(context.Roles, "Id", "Name", user.RoleId);
            return View(user);
        }

        public ActionResult Edit(int? id)
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(context.Roles, "Id", "Name", user.RoleId);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Password,Age,AboutMe,RoleId")] User user)
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            if (ModelState.IsValid)
            {
                context.Entry(user).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(context.Roles, "Id", "Name", user.RoleId);
            return View(user);
        }

        public ActionResult Delete(int? id)
        {
            ViewData["IsAuthenticated"] = "Authenticated";
            ViewData["IsAdmin"] = "Admin";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = context.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
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
