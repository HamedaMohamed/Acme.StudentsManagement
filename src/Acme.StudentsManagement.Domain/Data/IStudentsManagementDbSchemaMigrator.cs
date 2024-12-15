using System.Threading.Tasks;

namespace Acme.StudentsManagement.Data;

public interface IStudentsManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
