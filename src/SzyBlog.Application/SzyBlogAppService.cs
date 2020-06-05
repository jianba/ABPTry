using System;
using System.Collections.Generic;
using System.Text;
using SzyBlog.Localization;
using Volo.Abp.Application.Services;

namespace SzyBlog
{
    /* Inherit your application services from this class.
     */
    public abstract class SzyBlogAppService : ApplicationService
    {
        protected SzyBlogAppService()
        {
            LocalizationResource = typeof(SzyBlogResource);
        }
    }
}
