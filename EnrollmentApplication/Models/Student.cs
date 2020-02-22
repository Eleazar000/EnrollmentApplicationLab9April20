using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    { 
        [Key]  
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Display(Name = "Last Name")]
        
        [Required(ErrorMessage = "Enter Last Name")]  
        [MaxLength(50, ErrorMessage = " max is 50")]
        public virtual string LastName { get; set; }

        [Display(Name = "First Name")]

        [Required(ErrorMessage = "Enter value for First Name")]

        [MaxLength(50, ErrorMessage = "Allowable max length is 50")]
        public virtual string FirstName { get; set; }




    }
}