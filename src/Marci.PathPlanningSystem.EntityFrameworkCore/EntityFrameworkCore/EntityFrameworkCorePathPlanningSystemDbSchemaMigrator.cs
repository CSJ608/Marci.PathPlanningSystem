using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Marci.PathPlanningSystem.Data;
using Volo.Abp.DependencyInjection;

namespace Marci.PathPlanningSystem.EntityFrameworkCore;

public class EntityFrameworkCorePathPlanningSystemDbSchemaMigrator
    : IPathPlanningSystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePathPlanningSystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the PathPlanningSystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PathPlanningSystemDbContext>()
            .Database
            .MigrateAsync();
    }
}
