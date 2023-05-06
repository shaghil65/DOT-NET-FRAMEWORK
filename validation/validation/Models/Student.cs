using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace validation.Models
{
    public class Student
    {
        [Display(Name = "Id : ")]
        //[Required(ErrorMessage = "Student id is required.")]
        public int StudentId { get; set; }
        [Display(Name = "Name : ")]
        [Required(ErrorMessage = "Name is required.")]
        public string StudentName { get; set; }
        [Display(Name = "Age : ")]
        [Required(ErrorMessage = "Age is required.")]
        public int StudentAge { get; set; }
        [Display(Name = "Email : ")]
        [Required(ErrorMessage = "Email is required.")]
        public string StudentEmail { get; set; }
        [Display(Name = "Contact : ")]
        [Required(ErrorMessage = "Contact is required.")]
        public string StudentContact { get; set; }
    }
}