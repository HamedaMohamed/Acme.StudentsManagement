using Acme.StudentsManagement.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Acme.StudentsManagement.Student.Dtos
{
    public class StudentDto : EntityDto<Guid>
    {
        [Required(ErrorMessage = "Name is required.")]
        public  string Name { get; set; }=string.Empty;

        [Range(5, 18, ErrorMessage = "Age must be between 5 and 18.")]
        public int Age { get; set; }
        public string Grade { get; set; }

      
    }
}
