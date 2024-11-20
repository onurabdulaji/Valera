using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Dependencies.ContextDI
{
    public static class DBService
    {
        public static IServiceCollection AddContexts(this IServiceCollection services, IConfiguration configuration)
        {
            // IConfiguration doğrudan DI aracılığıyla alınır, BuildServiceProvider kullanılmaz
            services.AddDbContextPool<MyContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("MyConnection"))
                   .UseLazyLoadingProxies(); // Performans dikkat edilerek kullanılmalı
            });

            return services;
        }
    }
}
