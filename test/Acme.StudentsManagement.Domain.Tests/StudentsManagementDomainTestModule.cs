using Volo.Abp.Modularity;

namespace Acme.StudentsManagement;

[DependsOn(
    typeof(StudentsManagementDomainModule),
    typeof(StudentsManagementTestBaseModule)
)]
public class StudentsManagementDomainTestModule : AbpModule
{

}
