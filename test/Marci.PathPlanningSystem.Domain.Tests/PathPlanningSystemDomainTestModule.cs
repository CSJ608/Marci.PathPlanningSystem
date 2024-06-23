using Volo.Abp.Modularity;

namespace Marci.PathPlanningSystem;

[DependsOn(
    typeof(PathPlanningSystemDomainModule),
    typeof(PathPlanningSystemTestBaseModule)
)]
public class PathPlanningSystemDomainTestModule : AbpModule
{

}
