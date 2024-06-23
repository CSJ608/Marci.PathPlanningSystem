using Marci.PathPlanningSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Marci.PathPlanningSystem.Permissions;

public class PathPlanningSystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PathPlanningSystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PathPlanningSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PathPlanningSystemResource>(name);
    }
}
