using Microsoft.Extensions.DependencyInjection;
using PriceAPI.Common.Extensions;
using PriceAPI.Common.SettingsOptions;
using System;
using System.Collections.Generic;
using System.Text;


namespace PriceAPI.DAL.Infrastructure.Extensions
{
    public static class DIExtenstions
    {
        public static IServiceCollection RegisterApplicationDAL(this IServiceCollection services)
        {
            services.RegisterAssemblyServices(typeof(DIExtenstions).Assembly);
            return services;
        }
    }
}
