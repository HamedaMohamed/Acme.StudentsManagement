using Acme.StudentsManagement.Student.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StudentsManagement.Student
{
    public interface IStudentAppService : ICrudAppService<StudentDto,Guid, PagedAndSortedResultRequestDto, CreateUpdateStudentDto>
    {
        Task<StatisticsDto> GetStatisticsAsync();
    }
}
