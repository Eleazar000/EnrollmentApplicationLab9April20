using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Key] 
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Display(Name = "Course Title")]
        public virtual string CourseTitle { get; set; }
        [Required(ErrorMessage = "Enter Title for course")]  
        [MaxLength(50, ErrorMessage = "Allowable max is 150")]

        [Display(Name = "Description")]
        public virtual string CourseDescription { get; set; }

        [Display(Name = "Number of Credits")]
        
        [Required(ErrorMessage = "Enter credits for course")]
        [RegularExpression("^[1-4]{1}$", ErrorMessage = "Enter value either 1,2 or 3,4")]
        public virtual int CourseCredits { get; set; }


    }
}