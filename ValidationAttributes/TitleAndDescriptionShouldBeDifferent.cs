using BasicAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAPI.ValidationAttributes
{
    public class TitleAndDescriptionShouldBeDifferent : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForCreationDto)(validationContext.ObjectInstance);

            if(course.Title == course.Description)
            {
                return new ValidationResult(ErrorMessage, new[] { "CourseForCreationDto" });
            }

            return ValidationResult.Success;
        }
    }
}
