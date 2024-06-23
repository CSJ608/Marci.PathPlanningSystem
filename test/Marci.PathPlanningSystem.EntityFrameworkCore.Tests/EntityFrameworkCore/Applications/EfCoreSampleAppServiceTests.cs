using Marci.PathPlanningSystem.Samples;
using Xunit;

namespace Marci.PathPlanningSystem.EntityFrameworkCore.Applications;

[Collection(PathPlanningSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PathPlanningSystemEntityFrameworkCoreTestModule>
{

}
