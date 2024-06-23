using Marci.PathPlanningSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Marci.PathPlanningSystem.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PathPlanningSystemController : AbpControllerBase
{
    protected PathPlanningSystemController()
    {
        LocalizationResource = typeof(PathPlanningSystemResource);
    }
}
