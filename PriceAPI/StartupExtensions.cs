using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PriceAPI.BL.Infrastructure.Extensions;
using PriceAPI.Common.SettingsOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PriceAPI
{
    internal static class StartupExtensions
    {
        internal static void RegisterApplicationLayers(this IServiceCollection services)
        {
            services.RegisterApplicationBL();
        }

        internal static void RegisterApplicationOptions(this IServiceCollection services, IConfiguration configuration)
        {
            //config app settings here
            services.Configure<DatabaseOptions>(configuration.GetSection("Data"));
        }
    }
}
