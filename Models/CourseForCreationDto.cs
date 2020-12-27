using BasicAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicAPI.Models
{
    [TitleAndDescriptionShouldBeDifferent (ErrorMessage ="Title and Desc should be diff custom")]
    public class CourseForCreationDto //: IValidatableObject
    {
        [Required(ErrorMessage ="Title is Required id")]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(1500)]
        public string Description { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if(Title == Description)
        //    {
        //       yield return new ValidationResult("Both Title and Description should not be same", new[] { "CourseForCreationDto" });
        //    }
        //}
    }
}
