using SzyBlog.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SzyBlog.Permissions
{
    public class SzyBlogPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SzyBlogPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SzyBlogPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SzyBlogResource>(name);
        }
    }
}
