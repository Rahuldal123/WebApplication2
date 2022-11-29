using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            List<Employee> employees = new List<Employee>()
            {
               new Employee{Id=1,Name="Mahesh",Designation="Manager",salary=65000},
                new Employee{Id=2,Name="Ganesh",Designation="Developmentr",salary=55000},
                 new Employee{Id=3,Name="Naresh",Designation="Testing",salary=45000},
                  new Employee{Id=4,Name="Manoj",Designation="Testing",salary=47000},
                   new Employee{Id=5,Name="Shubham",Designation="Manager",salary=45000}
            };
            ViewData["emp list"] = employees;
            ViewBag.emplist = employees;
            return View();
        }
    }
}
