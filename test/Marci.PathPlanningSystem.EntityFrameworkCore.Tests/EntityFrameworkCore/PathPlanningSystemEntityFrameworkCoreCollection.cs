using Xunit;

namespace Marci.PathPlanningSystem.EntityFrameworkCore;

[CollectionDefinition(PathPlanningSystemTestConsts.CollectionDefinitionName)]
public class PathPlanningSystemEntityFrameworkCoreCollection : ICollectionFixture<PathPlanningSystemEntityFrameworkCoreFixture>
{

}
