using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SzyBlog.EntityFrameworkCore
{
    [DependsOn(
        typeof(SzyBlogEntityFrameworkCoreModule)
        )]
    public class SzyBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SzyBlogMigrationsDbContext>();
        }
    }
}
