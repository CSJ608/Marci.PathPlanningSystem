using Volo.Abp.Modularity;

namespace Marci.PathPlanningSystem;

/* Inherit from this class for your domain layer tests. */
public abstract class PathPlanningSystemDomainTestBase<TStartupModule> : PathPlanningSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
