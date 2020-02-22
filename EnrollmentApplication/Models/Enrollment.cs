using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }

        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }
        public virtual Student Student { get; set; }
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Display(Name = "Grade")]
        [RegularExpression("^[A-F]{1}$", ErrorMessage = "Enter value A , B, C, D, E, F")]
        public virtual string Grade { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Assigned Campus")]
       
        [Required(ErrorMessage = "Enter campus")]
        public string assignedCampus { get; set; }

        [Display(Name = "Enrolled in Semester")]
        [Required(ErrorMessage = "Enter enrollment semester")]
        public string EnrollmentSemester { get; set; }

        [Display(Name = "Enrollment Year")]
        [Required(ErrorMessage = "Enter Enrollment Year ")]
        [Range(2018, int.MaxValue, ErrorMessage = "Enter value greater than 2018")]
        public int EnrollmentYear { get; set; }


    }
}