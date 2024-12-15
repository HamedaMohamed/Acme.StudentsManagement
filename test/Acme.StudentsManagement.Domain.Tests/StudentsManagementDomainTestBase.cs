﻿using Volo.Abp.Modularity;

namespace Acme.StudentsManagement;

/* Inherit from this class for your domain layer tests. */
public abstract class StudentsManagementDomainTestBase<TStartupModule> : StudentsManagementTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}