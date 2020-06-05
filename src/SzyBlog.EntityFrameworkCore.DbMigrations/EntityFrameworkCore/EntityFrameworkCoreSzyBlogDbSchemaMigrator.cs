using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SzyBlog.Data;
using Volo.Abp.DependencyInjection;

namespace SzyBlog.EntityFrameworkCore
{
    public class EntityFrameworkCoreSzyBlogDbSchemaMigrator
        : ISzyBlogDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreSzyBlogDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the SzyBlogMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<SzyBlogMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}