using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student: IValidatableObject
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

        
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Address1 != null && Address2 == Address1)
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }
            if (State != null && State.Length >  2) 
            {
                yield return (new ValidationResult("Enter a 2 digit State code"));

            }

            if (Zipcode != null && Zipcode.Length>5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
                
            } 
            //throw new NotImplementedException();
        }
    }
}