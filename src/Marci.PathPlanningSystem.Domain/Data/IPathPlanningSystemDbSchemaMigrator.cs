using System.Threading.Tasks;

namespace Marci.PathPlanningSystem.Data;

public interface IPathPlanningSystemDbSchemaMigrator
{
    Task MigrateAsync();
}
