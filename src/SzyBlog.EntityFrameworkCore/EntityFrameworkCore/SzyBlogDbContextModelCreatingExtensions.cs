using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace SzyBlog.EntityFrameworkCore
{
    public static class SzyBlogDbContextModelCreatingExtensions
    {
        public static void ConfigureSzyBlog(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SzyBlogConsts.DbTablePrefix + "YourEntities", SzyBlogConsts.DbSchema);

            //    //...
            //});
        }
    }
}