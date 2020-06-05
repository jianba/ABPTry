using SzyBlog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SzyBlog.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SzyBlogPageModel : AbpPageModel
    {
        protected SzyBlogPageModel()
        {
            LocalizationResourceType = typeof(SzyBlogResource);
        }
    }
}