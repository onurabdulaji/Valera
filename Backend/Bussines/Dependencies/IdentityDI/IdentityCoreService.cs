using DataAccess.Context;
using Entity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Dependencies.IdentityDI
{
    public static class IdentityCoreService
    {
        public static IServiceCollection AddIdentities(this IServiceCollection services)
        {
            // Kullanıcı ve rol yönetimi için kimlik sistemini ekle
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.SignIn.RequireConfirmedEmail = true; // E-posta doğrulamasını zorunlu yap
            })
            .AddEntityFrameworkStores<MyContext>() // Veritabanı bağlama
            .AddDefaultTokenProviders(); // Token sağlayıcı (örneğin parola sıfırlama için)
            return services;
        }
    }
}
