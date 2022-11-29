using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace WebApplication2.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> list = new List<string>();
            list.Add("Yes");
            list.Add("No");
            ViewData["option"] = new SelectList(list);
            return View();
        }
        [HttpPost]

        public IActionResult PersonalDetails(IFormCollection form,ICollection<string>hobbies)
        {
            ViewBag.Name = form["fname"];
            ViewBag.Gender = form["gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Option = form["option"];
            return View("Details");
        }

    }
}
