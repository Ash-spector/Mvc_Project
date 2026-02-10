using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Mvc_Project.CustomValidations
{
    public class AgeValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult("Age is required");
            }

            // Convert value to string then try parse to avoid exceptions for non-int types
            string s = Convert.ToString(value);
            if (!int.TryParse(s, out int age))
            {
                return new ValidationResult("Age must be a number");
            }

            if (age > 18)
                return ValidationResult.Success;

            return new ValidationResult("Age must be greater than 18");
        }
    }
}