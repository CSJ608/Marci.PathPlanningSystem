using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Marci.PathPlanningSystem.Data;

/* This is used if database provider does't define
 * IPathPlanningSystemDbSchemaMigrator implementation.
 */
public class NullPathPlanningSystemDbSchemaMigrator : IPathPlanningSystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
