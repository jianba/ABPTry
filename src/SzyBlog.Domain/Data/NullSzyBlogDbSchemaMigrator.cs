using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SzyBlog.Data
{
    /* This is used if database provider does't define
     * ISzyBlogDbSchemaMigrator implementation.
     */
    public class NullSzyBlogDbSchemaMigrator : ISzyBlogDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}