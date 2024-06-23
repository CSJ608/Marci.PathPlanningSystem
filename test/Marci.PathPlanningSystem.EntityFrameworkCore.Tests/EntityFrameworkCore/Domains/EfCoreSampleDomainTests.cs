using Marci.PathPlanningSystem.Samples;
using Xunit;

namespace Marci.PathPlanningSystem.EntityFrameworkCore.Domains;

[Collection(PathPlanningSystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PathPlanningSystemEntityFrameworkCoreTestModule>
{

}
