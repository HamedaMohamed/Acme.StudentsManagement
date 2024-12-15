using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.StudentsManagement.Students
{
    public class Student : FullAuditedEntity<Guid> 
    {
        public required string Name { get; set; }        
        public required int Age { get; set; }           
        public required string Grade { get; set; }
    }
}