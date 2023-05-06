using StudentsDB.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentsDB.ViewModels.Home
{
    public class StudentsViewModel
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            using (StudentsDBContext db = new StudentsDBContext())
            {
                students = db.Students.ToList();
            }
            return students;
        }

        internal void SaveNewRecord(Student student)
        {
            using (StudentsDBContext db = new StudentsDBContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public Student GetStudentByDetails(int id)
        {
            Student student = new Student();
            using (StudentsDBContext db = new StudentsDBContext())
            {
                student = db.Students.Where(x => x.StudentId == id).First();
            }
            return student;
        }

        internal List<Student> SearchStudent(string searchterm)
        {
            List<Student> students = new List<Student>();
            using (StudentsDBContext db = new StudentsDBContext())
            {
                students = db.Students.Where(x => x.FirstName.Contains(searchterm)).ToList();
            }
            return students;
        }

        internal void UpdateStudentDetails(Student student)
        {
            using (StudentsDBContext db = new StudentsDBContext())
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void DeleteStudentById(int id)
        {
            Student student = new Student() { StudentId = id};
            using (StudentsDBContext db = new StudentsDBContext())
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }

    }
}