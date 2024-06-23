using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Marci.PathPlanningSystem.Web;

[Dependency(ReplaceServices = true)]
public class PathPlanningSystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PathPlanningSystem";
}
