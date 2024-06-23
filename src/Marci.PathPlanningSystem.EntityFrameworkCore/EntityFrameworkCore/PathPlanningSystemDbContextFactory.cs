using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Marci.PathPlanningSystem.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class PathPlanningSystemDbContextFactory : IDesignTimeDbContextFactory<PathPlanningSystemDbContext>
{
    public PathPlanningSystemDbContext CreateDbContext(string[] args)
    {
        PathPlanningSystemEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PathPlanningSystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new PathPlanningSystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Marci.PathPlanningSystem.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
