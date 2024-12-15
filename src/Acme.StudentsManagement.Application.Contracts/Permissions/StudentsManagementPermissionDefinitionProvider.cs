using Acme.StudentsManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.StudentsManagement.Permissions;

public class StudentsManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(StudentsManagementPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(StudentsManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<StudentsManagementResource>(name);
    }
}
