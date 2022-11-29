using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Plist()
        {
            List<Product> list = new List<Product>()
            {
                new Product{Id=1,ProductName="Vivo V21",Company="Vivo",Price=25000},
                new Product{Id=2,ProductName="Realme 9",Company="Realme",Price=18000},
                new Product{Id=3,ProductName="Oppo F19",Company="OPPO",Price=19000},
                new Product{Id=4,ProductName="Redmi 10A",Company="Xiaomi",Price=14000},
                new Product{Id=5,ProductName="Poco M4",Company="POCO",Price=15000},
                new Product{Id=6,ProductName="S22 Ultra",Company="SamSung",Price=65000},
                new Product{Id=7,ProductName="Iphone 13",Company="Apple",Price=75000}
            };
            ViewBag.ProductList = list;
            return View();
        }
    }
}
