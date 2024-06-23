using Marci.PathPlanningSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Marci.PathPlanningSystem.Web.Pages;

public abstract class PathPlanningSystemPageModel : AbpPageModel
{
    protected PathPlanningSystemPageModel()
    {
        LocalizationResourceType = typeof(PathPlanningSystemResource);
    }
}
