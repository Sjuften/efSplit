﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace entityFramework.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
//            services.AddIdentity<ApplicationUser, IdentityRole>(opts =>
//            {
//                opts.User.RequireUniqueEmail = true;
//                opts.Password.RequiredLength = 6;
//                opts.Password.RequireNonAlphanumeric = false;
//                opts.Password.RequireLowercase = false;
//                opts.Password.RequireUppercase = false;
//                opts.Password.RequireDigit = false;
//            }).AddEntityFrameworkStores<EsportshubContext>();

            return services;
        }

        public static IServiceCollection SetIdentityConfiguration(this IServiceCollection services)
        {
//            services.Configure<IdentityOptions>(options =>
//            {
//                // Password settings
//                options.Password.RequireDigit = true;
//                options.Password.RequiredLength = 8;
//                options.Password.RequireNonAlphanumeric = false;
//                options.Password.RequireUppercase = true;
//                options.Password.RequireLowercase = false;
//
//                // Lockout settings
//                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
//                options.Lockout.MaxFailedAccessAttempts = 10;
//
//                // Cookie settings
//                options.Cookies.ApplicationCookie.ExpireTimeSpan = TimeSpan.FromDays(150);
//                options.Cookies.ApplicationCookie.LoginPath = "/Account/LogIn";
//                options.Cookies.ApplicationCookie.LogoutPath = "/Account/LogOff";
//
//                // User settings
//                options.User.RequireUniqueEmail = true;
//            });
            return services;
        }
    }
}