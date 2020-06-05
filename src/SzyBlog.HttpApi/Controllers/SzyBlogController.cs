using SzyBlog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SzyBlog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SzyBlogController : AbpController
    {
        protected SzyBlogController()
        {
            LocalizationResource = typeof(SzyBlogResource);
        }
    }
}