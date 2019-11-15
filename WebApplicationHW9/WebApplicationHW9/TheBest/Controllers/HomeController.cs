using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheBest.DataAccess;
using TheBest.Models;

namespace TheBest.Controllers
{
    public class HomeController : Controller
    {
        private readonly CardContext _context;
        public HomeController(CardContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.Cards.ToList();
            ViewData["Posts"] = posts;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
