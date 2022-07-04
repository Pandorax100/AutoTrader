using System.Collections.Specialized;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Authorization;
using Pandorax.AutoTrader.Constants;
using Pandorax.AutoTrader.Converters;
using Pandorax.AutoTrader.Models;
using Pandorax.AutoTrader.Models.Images;
using Pandorax.AutoTrader.Options;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader
{
    internal class AutoTraderService : IAutoTraderService
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
        };

        private readonly HttpClient _client;

        public AutoTraderService(HttpClient client)
        {
            _client = client;
        }

        public AutoTraderNotification? ParseNotificationJson(string json)
        {
            return JsonSerializer.Deserialize<AutoTraderNotification>(json, JsonSerializerOptions);
        }

        /// <inheritdoc />
        public async Task<StockListResult?> GetStockAsync(
            int pageSize = 20,
            int? page = null,
            string? advertiserId = null,
            LifecycleState? lifecycleState = null,
            string? searchId = null,
            string? stockId = null,
            string? registration = null,
            string? vin = null)
        {
            NameValueCollection query = BuildStockQueryString(advertiserId, pageSize, page, lifecycleState, searchId, stockId, registration, vin);

            string url = Endpoints.SearchEndpoint(query);

            string json = await _client.GetStringAsync(url);

            StockListResult? parsed = JsonSerializer.Deserialize<StockListResult>(json, JsonSerializerOptions);

            return parsed;
        }

        /// <inheritdoc />
        public async Task<List<AutoTraderVehicleData>> GetAllStockAsync(
            int pageSize = 20,
            string? advertiserId = null,
            LifecycleState? lifecycleState = null,
            string? searchId = null,
            string? stockId = null,
            string? registration = null,
            string? vin = null)
        {
            List<AutoTraderVehicleData> vehicles = new();

            int page = 1;
            while (true)
            {
                StockListResult? stock = await GetStockAsync(
                    pageSize,
                    page,
                    advertiserId,
                    lifecycleState: lifecycleState,
                    searchId: searchId,
                    stockId: stockId,
                    registration: registration,
                    vin: vin);

                if (stock is null)
                {
                    break;
                }

                vehicles.AddRange(stock.Results);

                if (vehicles.Count >= stock.TotalResults)
                {
                    break;
                }

                page++;
            }

            return vehicles;
        }

        public async Task<AutoTraderVehicleData> CreateStockAsync(int advertiserId, AutoTraderVehicleData vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle);

            string json = JsonSerializer.Serialize(vehicle);

            string url = Endpoints.CreateStockEndpoint(advertiserId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseBody = await response.Content.ReadAsStringAsync();

            AutoTraderVehicleData? deserialised = await response.Content.ReadFromJsonAsync<AutoTraderVehicleData>();

            return deserialised!;
        }

        public async Task<AutoTraderVehicleData> UpdateStockAsync(string stockId, AutoTraderVehicleData vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle);
            ArgumentNullException.ThrowIfNull(vehicle.Metadata);
            ArgumentNullException.ThrowIfNull(stockId);

            string json = JsonSerializer.Serialize(vehicle);

            string url = Endpoints.UpdateStockEndpoint(stockId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseJson = await response.Content.ReadAsStringAsync();

            var deserialized = JsonSerializer.Deserialize<AutoTraderVehicleData>(responseJson);

            return deserialized!;
        }

        private static NameValueCollection BuildStockQueryString(
          string? advertiserId,
          int pageSize,
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
                ["pageSize"] = pageSize.ToString(),
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
    }
}
