using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Pandorax.AutoTrader.Options;

namespace Pandorax.AutoTrader
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoTraderClient(
            this IServiceCollection services,
            Action<AutoTraderOptions> configureOptions)
        {
            services.AddHttpClient<IAutoTraderService, AutoTraderService>();
            services.Configure(configureOptions);

            return services;
        }
    }
}
