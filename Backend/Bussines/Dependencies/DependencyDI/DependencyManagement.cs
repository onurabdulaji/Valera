using Bussines.ManagerServices.Abstracts;
using Bussines.ManagerServices.Concretes;
using DataAccess.Repositories.Abstracts;
using DataAccess.Repositories.Concretes;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Dependencies.DependencyDI
{
    public static class DependencyManagement
    {
        public static IServiceCollection DependencyManagers(this IServiceCollection services, IConfiguration configuration)
        {
            // Bases
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            // Dependencies 
            services.AddScoped<IApplicationUserManager, ApplicationUserManager>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();


            services.AddScoped<IHeroManager, HeroManager>();
            services.AddScoped<IHeroRepository, HeroRepository>();

            return services;
        }
    }
}
