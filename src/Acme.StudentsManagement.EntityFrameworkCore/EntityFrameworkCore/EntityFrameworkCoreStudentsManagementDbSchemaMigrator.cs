using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.StudentsManagement.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentsManagement.EntityFrameworkCore;

public class EntityFrameworkCoreStudentsManagementDbSchemaMigrator
    : IStudentsManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreStudentsManagementDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the StudentsManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<StudentsManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
