using Volo.Abp.Modularity;

namespace Marci.PathPlanningSystem;

public abstract class PathPlanningSystemApplicationTestBase<TStartupModule> : PathPlanningSystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
