using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidChar : ValidationAttribute
    {
        //readonly string invalidChar;
        public string InvalidCharVal { get; set; }

        
        
      /*  public InvalidChar(string invalidChar)
        {
            this.invalidChar = invalidChar;
        }*/
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value!=null)
            {
               
                string str = value as string;
                if(str!=null && str.Contains(InvalidCharVal))
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }

            }
            return ValidationResult.Success;
        }

    }

        
    }
