using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.StudentsManagement.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class StudentsManagementDbContextFactory : IDesignTimeDbContextFactory<StudentsManagementDbContext>
{
    public StudentsManagementDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        StudentsManagementEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<StudentsManagementDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new StudentsManagementDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Acme.StudentsManagement.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
