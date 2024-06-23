using System;
using System.Collections.Generic;
using System.Text;
using Marci.PathPlanningSystem.Localization;
using Volo.Abp.Application.Services;

namespace Marci.PathPlanningSystem;

/* Inherit your application services from this class.
 */
public abstract class PathPlanningSystemAppService : ApplicationService
{
    protected PathPlanningSystemAppService()
    {
        LocalizationResource = typeof(PathPlanningSystemResource);
    }
}
