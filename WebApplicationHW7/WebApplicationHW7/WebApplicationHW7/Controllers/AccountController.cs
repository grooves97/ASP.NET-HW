using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplicationHW7.DataAccess;
using WebApplicationHW7.Models;
using WebApplicationHW7.ViewModel;

namespace WebApplicationHW7.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = null;

                using (UserContext context = new UserContext())
                {
                    user = context.Users.FirstOrDefault(x => x.Email == loginViewModel.Name && x.Password == loginViewModel.Password);
                }
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(loginViewModel.Name, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логинем и паролем не существует");
                }
            }

            return View(loginViewModel);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                User user = null;
                using (UserContext context = new UserContext())
                {
                    user = context.Users.FirstOrDefault(x => x.Email == registerViewModel.Name);
                }

                if (user == null)
                {
                    using (UserContext context = new UserContext())
                    {
                        context.Users.Add(new User { Email = registerViewModel.Name, Password = registerViewModel.Password, Age = registerViewModel.Age, RoleId = 2 });
                        context.SaveChanges();

                        user = context.Users.Where(x => x.Email == registerViewModel.Name && x.Password == registerViewModel.Password).FirstOrDefault();
                    }

                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(registerViewModel.Name, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(registerViewModel);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}