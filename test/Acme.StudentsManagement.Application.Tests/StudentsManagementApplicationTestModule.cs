using Volo.Abp.Modularity;

namespace Acme.StudentsManagement;

[DependsOn(
    typeof(StudentsManagementApplicationModule),
    typeof(StudentsManagementDomainTestModule)
)]
public class StudentsManagementApplicationTestModule : AbpModule
{

}
