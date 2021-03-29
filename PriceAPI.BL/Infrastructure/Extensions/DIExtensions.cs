using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PriceAPI.Common.Extensions;
using PriceAPI.DAL.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PriceAPI.BL.Infrastructure.Extensions
{
    public static class DIExtensions
    {
        public static IServiceCollection RegisterApplicationBL(this IServiceCollection services)
        {
            services.RegisterApplicationDAL();

            services.RegisterAssemblyServices(typeof(DIExtensions).Assembly);
            services.RegisterAutoMapper();

            return services;
        }

        internal static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DIExtensions).Assembly);
            return services;
        }
    }
}
