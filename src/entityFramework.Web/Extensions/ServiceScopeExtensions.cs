using System;
using entityFramework.Data.Databases;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace entityFramework.Web.Extensions
{
    public static class ServiceScopeExtensions
    {

        public static void Migrate(this IServiceScope serviceScope,IApplicationBuilder app)
        {
//            if (serviceScope == null) throw new ArgumentNullException(nameof(serviceScope));
//            serviceScope.ServiceProvider.GetService<MyDbContext>().Database.Migrate();
//            serviceScope.Dispose();
        }

        public static void SeedData(this IServiceScope serviceScope,IApplicationBuilder app)
        {
            if (serviceScope == null) throw new ArgumentNullException(nameof(serviceScope));
            serviceScope.ServiceProvider.GetService<MyDbContext>().EnsureSeedDataForContext();
            serviceScope.Dispose();
        }
    }
}