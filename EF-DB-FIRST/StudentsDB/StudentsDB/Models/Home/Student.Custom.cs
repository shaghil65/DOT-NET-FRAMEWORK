using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentsDB.Models.DB
{
    [MetadataType(typeof(StudentMetaData))]
    public partial class Student
    {       
    }
    public class StudentMetaData
    {
        [Required(ErrorMessage = "Student Id is required.")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Student firstname is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Student lastname is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Student email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Student mobile is required.")]
        public string Mobile { get; set; }

    }
}