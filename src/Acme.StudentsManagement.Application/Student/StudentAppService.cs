using Acme.StudentsManagement.Student.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentsManagement.Student
{
    public class StudentAppService : CrudAppService<Students.Student, StudentDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateStudentDto>, IStudentAppService
    {
        private readonly IRepository<Students.Student, Guid> _repository;

        public StudentAppService(IRepository<Students.Student, Guid> repository) : base(repository)
        {
            _repository=repository;
        }

        public async Task<StatisticsDto> GetStatisticsAsync()
        {
            var totalStudents = await _repository.CountAsync();
            var averageAge = await _repository
                .AverageAsync(student => student.Age);

            var gradeDistribution =  _repository.GetListAsync().Result
                .GroupBy(student => student.Grade)
                .ToDictionary(g => g.Key, g => g.Count());

            return new StatisticsDto
            {
                TotalStudents = totalStudents,
                AverageAge = averageAge,
                GradeDistribution = gradeDistribution
            };
        }
    }
}
