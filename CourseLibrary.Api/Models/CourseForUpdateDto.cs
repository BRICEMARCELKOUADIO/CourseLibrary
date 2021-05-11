using CourseLibrary.Api.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.Api.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        public override string Description { get => base.Description; set => base.Description = value; }
    }
}
