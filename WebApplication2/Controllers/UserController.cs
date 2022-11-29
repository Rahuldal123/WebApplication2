using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Adduser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adduser(user u1)
        {
            return View();
        }
    }
}
