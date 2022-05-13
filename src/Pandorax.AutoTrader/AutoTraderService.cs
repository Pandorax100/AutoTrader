using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Constants;
using Pandorax.AutoTrader.Models;
using Pandorax.AutoTrader.Options;

namespace Pandorax.AutoTrader
{
    public class AutoTraderService : IAutoTraderService
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };

        private readonly AutoTraderOptions _options;
        private readonly HttpClient _client;

        public AutoTraderService(
            IOptions<AutoTraderOptions> options,
            HttpClient client)
        {
            _options = options.Value;
            _client = client;

            if (_options.BaseApiUrl is not null)
            {
                _client.BaseAddress = _options.BaseApiUrl;
            }
            else
            {
                var baseAddress = _options.UseSandboxEnvironment
                    ? AutoTraderConstants.SandboxBaseUrl
                    : AutoTraderConstants.ProductionBaseUrl;

                _client.BaseAddress = new Uri(baseAddress);
            }
        }

        public AutoTraderNotification? ParseNotificationJson(string json)
        {
            return JsonSerializer.Deserialize<AutoTraderNotification>(json, JsonSerializerOptions);
        }

        public async Task<StockListResult?> GetStockByAdvertiserIdAsync(string advertiserId)
        {
            if (advertiserId is null)
            {
                throw new ArgumentNullException(nameof(advertiserId));
            }

            string? accessToken = await GetAccessTokenAsync();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            string? json = await _client.GetStringAsync($"/service/stock-management/stock?advertiserId={advertiserId}");

            StockListResult? parsed = JsonSerializer.Deserialize<StockListResult>(json, JsonSerializerOptions);

            return parsed;
        }

        private async Task<string?> GetAccessTokenAsync()
        {
            using FormUrlEncodedContent body = new(new Dictionary<string, string>
            {
                ["key"] = _options.ApiKey,
                ["secret"] = _options.ApiSecret,
            });

            using HttpResponseMessage? response = await _client.PostAsync("/authenticate", body);

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            JsonElement parsed = (JsonElement)JsonSerializer.Deserialize<object>(json);

            return parsed.GetProperty("access_token").GetString();
        }
    }
}
