using CourseLibrary.Api.Entities;
using CourseLibrary.Api.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.Api.Models
{
    public class CourseForCreationDto : CourseForManipulationDto
    {
        public Author Author { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Title == Description)
        //    {
        //       yield return new ValidationResult("The provided description should be different from the title.", new[] { "CourseForCreationDto" });
        //    }
        //}
    }
}
