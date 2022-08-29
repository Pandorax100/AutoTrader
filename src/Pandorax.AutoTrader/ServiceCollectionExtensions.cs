using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Authorization;
using Pandorax.AutoTrader.Constants;
using Pandorax.AutoTrader.Options;
using Pandorax.AutoTrader.Services;

namespace Pandorax.AutoTrader;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAutoTraderClient(
        this IServiceCollection services,
        Action<AutoTraderOptions> configureOptions)
    {
        services.AddTransient<AccessTokenDelegatingHandler>();

        services
            .AddHttpClient(
                "AutoTrader",
                (provider, client) => SetBaseAddress(provider, client))
            .AddHttpMessageHandler<AccessTokenDelegatingHandler>();

        services.AddHttpClient<IAutoTraderService, AutoTraderService>("AutoTrader");

        services.AddHttpClient<IAutoTraderTaxonomyService, AutoTraderTaxonomyService>("AutoTrader");

        services
            .AddHttpClient<AccessTokenHandler>((provider, client) =>
            {
                SetBaseAddress(provider, client);
            });

        services.Configure(configureOptions);

        return services;
    }

    private static void SetBaseAddress(IServiceProvider provider, HttpClient client)
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
    }
}
