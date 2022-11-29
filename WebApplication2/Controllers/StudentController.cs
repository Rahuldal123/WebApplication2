using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System.Collections.Generic;
namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
     
        public IActionResult SList()
        {

            List<Student> students = new List<Student>()
          {
            new Student{Rollno=10,Name="Suraj",Percentage=79.20},
            new Student{Rollno=11,Name="Naresh",Percentage=76.89},
            new Student{Rollno=12,Name="Ganesh",Percentage=77.20},
            new Student{Rollno=13,Name="Raj",Percentage=89.20},
          };
            ViewData["students"]=students;
            ViewBag.studentlist = students;
            
            return View();
        }
    }
}
