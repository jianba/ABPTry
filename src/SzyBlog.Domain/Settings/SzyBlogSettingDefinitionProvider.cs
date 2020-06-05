using Volo.Abp.Settings;

namespace SzyBlog.Settings
{
    public class SzyBlogSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SzyBlogSettings.MySetting1));
        }
    }
}
