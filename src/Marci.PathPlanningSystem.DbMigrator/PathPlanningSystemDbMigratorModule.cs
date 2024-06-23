using Marci.PathPlanningSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace Marci.PathPlanningSystem.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(PathPlanningSystemEntityFrameworkCoreModule),
    typeof(PathPlanningSystemApplicationContractsModule)
    )]
public class PathPlanningSystemDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "PathPlanningSystem:"; });
    }
}
