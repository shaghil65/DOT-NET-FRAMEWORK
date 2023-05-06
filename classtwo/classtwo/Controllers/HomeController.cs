using classtwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classtwo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Student student1 = new Student() {studentId = 101,studentName="Shaghil" };
            Student student2 = new Student() { studentId = 102, studentName = "Bilal" };

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            return View(students);
        }
        public ActionResult ContactUs()
        {
            return View();
        }
    }
}