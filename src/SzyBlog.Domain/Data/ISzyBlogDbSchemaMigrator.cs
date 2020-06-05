using System.Threading.Tasks;

namespace SzyBlog.Data
{
    public interface ISzyBlogDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
