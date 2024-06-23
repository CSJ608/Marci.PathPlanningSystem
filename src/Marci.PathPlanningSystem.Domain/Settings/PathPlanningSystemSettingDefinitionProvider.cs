using Volo.Abp.Settings;

namespace Marci.PathPlanningSystem.Settings;

public class PathPlanningSystemSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PathPlanningSystemSettings.MySetting1));
    }
}
