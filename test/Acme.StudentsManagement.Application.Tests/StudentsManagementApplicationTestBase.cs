using Volo.Abp.Modularity;

namespace Acme.StudentsManagement;

public abstract class StudentsManagementApplicationTestBase<TStartupModule> : StudentsManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
