using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]

        public IActionResult ContactUs(IFormCollection form)
        {
            ViewBag.name = form["fname"];
            ViewBag.Email = form["email"];
            ViewBag.Contact = form["cono"];
            ViewBag.Message = form["message"];

            return View("codetails");
        }
    }
}
