using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentsManagement.Data;

/* This is used if database provider does't define
 * IStudentsManagementDbSchemaMigrator implementation.
 */
public class NullStudentsManagementDbSchemaMigrator : IStudentsManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
