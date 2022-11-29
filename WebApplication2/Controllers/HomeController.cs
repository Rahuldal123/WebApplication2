using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is Sample";
            ViewData["Name"] = "My name is Rahul";
            ViewData["per"] = 79.36;
            List<String> colors = new List<string>()
            {
                "red","Orange","Green","Yellow","Blue"
            };
            ViewData["colors"] = colors;
            ViewBag.Username = "Rahuldalwale55";
            ViewBag.City = "pune";
            ViewBag.colors = colors;
            Dictionary<String, int> colours = new Dictionary<string, int>();
            colours.Add("red", 1);
            colours.Add("blue", 2);
            ViewBag.colours = colours;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Aboutus()
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