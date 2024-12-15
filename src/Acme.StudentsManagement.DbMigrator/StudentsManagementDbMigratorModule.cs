﻿using Acme.StudentsManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.StudentsManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentsManagementEntityFrameworkCoreModule),
    typeof(StudentsManagementApplicationContractsModule)
)]
public class StudentsManagementDbMigratorModule : AbpModule
{
}
