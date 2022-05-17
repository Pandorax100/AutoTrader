using System.Collections.Specialized;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
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

        /// <inheritdoc />
        public async Task<StockListResult?> GetStockAsync(
            string? advertiserId = null,
            int? pageSize = null,
            int? page = null,
            LifecycleState? lifecycleState = null,
            string? searchId = null,
            string? stockId = null,
            string? registration = null,
            string? vin = null)
        {
            string? accessToken = await GetAccessTokenAsync();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var query = BuildStockQueryString(advertiserId, pageSize, page, lifecycleState, searchId, stockId, registration, vin);

            var url = string.Concat($"/service/stock-management/stock", query.Count > 0 ? "?" : null, query);

            string json = await _client.GetStringAsync(url);

            StockListResult? parsed = JsonSerializer.Deserialize<StockListResult>(json, JsonSerializerOptions);

            return parsed;
        }

        private static NameValueCollection BuildStockQueryString(
          string? advertiserId,
          int? pageSize,
          int? page,
          LifecycleState? lifecycleState,
          string? searchId,
          string? stockId,
          string? registration,
          string? vin)
        {
            Dictionary<string, string?> queryString = new()
            {
                ["advertiserId"] = advertiserId,
                ["pageSize"] = pageSize?.ToString(),
                ["page"] = page?.ToString(),
                ["lifecycleState"] = lifecycleState switch
                {
                    LifecycleState.Deleted => "DELETED",
                    LifecycleState.Forecourt => "FORECOURT",
                    LifecycleState.SaleInProgress => "SALE_IN_PROGRESS",
                    LifecycleState.DueIn => "DUE_IN",
                    LifecycleState.Wastebin => "WASTEBIN",
                    _ => null,
                },
                ["searchId"] = searchId,
                ["stockId"] = stockId,
                ["registration"] = registration,
                ["vin"] = vin,
            };

            NameValueCollection query = HttpUtility.ParseQueryString(string.Empty);

            foreach (var (key, value) in queryString)
            {
                if (value is not null)
                {
                    query.Add(key, value);
                }
            }

            return query;
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

            JsonElement? parsed = (JsonElement?)JsonSerializer.Deserialize<object>(json);

            return parsed?.GetProperty("access_token").GetString();
        }
    }
}
