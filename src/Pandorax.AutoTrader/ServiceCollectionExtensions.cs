using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Constants;
using Pandorax.AutoTrader.Options;
using Pandorax.AutoTrader.Services;

namespace Pandorax.AutoTrader
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAutoTraderClient(
            this IServiceCollection services,
            Action<AutoTraderOptions> configureOptions)
        {
            services.AddHttpClient("AutoTrader", (provider, client) =>
            {
                var optionsAccessor = provider.GetRequiredService<IOptions<AutoTraderOptions>>();
                var options = optionsAccessor.Value;
                if (options.BaseApiUrl is not null)
                {
                    client.BaseAddress = options.BaseApiUrl;
                }
                else
                {
                    var baseAddress = options.UseSandboxEnvironment
                        ? AutoTraderConstants.SandboxBaseUrl
                        : AutoTraderConstants.ProductionBaseUrl;

                    client.BaseAddress = new Uri(baseAddress);
                }
            });

            services.AddHttpClient<IAutoTraderService, AutoTraderService>("AutoTrader");
            services.AddHttpClient<AccessTokenHandler>("AutoTrader");
            services.Configure(configureOptions);

            return services;
        }
    }
}
