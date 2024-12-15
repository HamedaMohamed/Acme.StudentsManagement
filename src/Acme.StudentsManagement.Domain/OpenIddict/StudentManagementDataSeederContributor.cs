using Acme.StudentsManagement.Enum;
using Acme.StudentsManagement.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentsManagement.OpenIddict
{
    public class StudentManagementDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _StudentRepository;

        public StudentManagementDataSeederContributor(IRepository<Student, Guid> StudentRepository)
        {
            _StudentRepository = StudentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _StudentRepository.GetCountAsync() <= 0)
            {
                await _StudentRepository.InsertAsync(
                    new Student
                    {
                        Name = "Ahmed Ali",
                        Age=6,
                        Grade=Grade.Grade1.ToString()
                    },
                    autoSave: true
                );

                await _StudentRepository.InsertAsync(
                     new Student
                     {
                         Name = "Aya Ahmed",
                         Age=7,
                         Grade=Grade.Grade2.ToString()
                     },
                     autoSave: true
                 );  await _StudentRepository.InsertAsync(
                     new Student
                     {
                         Name = "Aya Ali",
                         Age=8,
                         Grade=Grade.Grade3.ToString()
                     },
                     autoSave: true
                 );  await _StudentRepository.InsertAsync(
                     new Student
                     {
                         Name = "Ali Ahmed",
                         Age=9,
                         Grade=Grade.Grade4.ToString()
                     },
                     autoSave: true
                 );
            }
        }
    }
}