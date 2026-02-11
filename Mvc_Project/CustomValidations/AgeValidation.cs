using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Mvc_Project.CustomValidations
{
    public class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
          int age = Convert.ToInt32(value);

            if (age > 18&& age<25)
                return ValidationResult.Success;

            return new ValidationResult("Age must be greater than 18");
        }
    }
}