using Volo.Abp.Modularity;

namespace Marci.PathPlanningSystem;

[DependsOn(
    typeof(PathPlanningSystemApplicationModule),
    typeof(PathPlanningSystemDomainTestModule)
)]
public class PathPlanningSystemApplicationTestModule : AbpModule
{

}
