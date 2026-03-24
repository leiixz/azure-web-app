using Microsoft.AspNetCore.Mvc;

namespace PortfolioDemo.Controllers
{
    public class HomeController : Controller
    {
        // Home page
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            ViewData["ActiveTab"] = "Home";
            return View();
        }

        // Projects page
        public IActionResult Projects()
        {
            ViewData["Title"] = "Projects";
            ViewData["ActiveTab"] = "Projects";
            return View();
        }

        // About Me page
        public IActionResult About()
        {
            ViewData["Title"] = "About Me";
            ViewData["ActiveTab"] = "About";
            return View();
        }

        // Contact page
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact";
            ViewData["ActiveTab"] = "Contact";
            return View();
        }
    }
}