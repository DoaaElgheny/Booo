using PortalDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PortalDemo.Permissions;

public class PortalDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PortalDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PortalDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PortalDemoResource>(name);
    }
}
