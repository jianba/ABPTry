using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace SzyBlog.Web
{
    [Dependency(ReplaceServices = true)]
    public class SzyBlogBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SzyBlog";
    }
}
