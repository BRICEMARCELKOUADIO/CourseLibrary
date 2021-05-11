using CourseLibrary.Api.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.Api.Models
{
    [CourseTitleMustBeDifferentFromDescrition(ErrorMessage = "Title must be different from description")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You shoul fill out a title")]
        [MaxLength(100)]
        public abstract string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The description shouldn't have more than 1500 characters.")]
        public abstract string Description { get; set; }

    }
}
