using StudentsDB.Models.DB;
using StudentsDB.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentsDB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students = new List<Student>();
            StudentsViewModel svm = new StudentsViewModel();
            students = svm.GetStudents();
            return View(students);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Index(string searchterm)
        {
            List<Student> students = new List<Student>();
            StudentsViewModel svm = new StudentsViewModel();
            students = svm.SearchStudent(searchterm);
            return View(students);
        }
        public ActionResult NewStudent()
        {
            return View();
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult NewStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentsViewModel svm = new StudentsViewModel();
                svm.SaveNewRecord(student);

                return RedirectToAction("Index", "Home");   
            }
            return View();
        }
        public ActionResult UpdateStudent(int id)
        {
            StudentsViewModel svm = new StudentsViewModel();
            Student student = svm.GetStudentByDetails(id);

            return View(student);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult UpdateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                StudentsViewModel svm = new StudentsViewModel();
                svm.UpdateStudentDetails(student);

                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public ActionResult DeleteStudent(int id = 0)
        {

            if (id != 0)
            {
                StudentsViewModel svm = new StudentsViewModel();
                svm.DeleteStudentById(id);
            }
            return RedirectToAction("Index", "Home");   
        }
    }
}