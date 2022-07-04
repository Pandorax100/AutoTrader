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
using Pandorax.AutoTrader.Models.Stock;
using Pandorax.AutoTrader.Models.Vehicles;
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
        public async Task<StockListResult?> GetStockAsync(StockSearchParameters parameters)
        {
            string url = Endpoints.SearchEndpoint(parameters);

            string json = await _client.GetStringAsync(url);

            StockListResult? parsed = JsonSerializer.Deserialize<StockListResult>(json, JsonSerializerOptions);

            return parsed;
        }

        /// <inheritdoc />
        public async Task<List<AutoTraderVehicleData>> GetAllStockAsync(StockSearchParameters parameters)
        {
            List<AutoTraderVehicleData> vehicles = new();

            parameters.Page = 1;

            while (true)
            {
                StockListResult? stock = await GetStockAsync(parameters);

                if (stock is null)
                {
                    break;
                }

                vehicles.AddRange(stock.Results);

                if (vehicles.Count >= stock.TotalResults)
                {
                    break;
                }

                parameters.Page++;
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

        public async Task<string> UploadImageAsync(int advertiserId, Stream stream, string contentType, string fileName)
        {
            using var streamContent = new StreamContent(stream);
            using var multipartFormContent = new MultipartFormDataContent();

            var content = new StreamContent(stream);
            content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            multipartFormContent.Add(content, "file", fileName);

            using HttpResponseMessage response = await _client.PostAsync(Endpoints.UploadImage(advertiserId), multipartFormContent);

            response.EnsureSuccessStatusCode();

            ImageCreatedResponse? responseJson = await response.Content.ReadFromJsonAsync<ImageCreatedResponse>();

            return responseJson!.ImageId;
        }

        public async Task<VehicleRoot?> GetVehicleDataAsync(
            int advertiserId,
            string vehicleRegistration,
            bool includeMots = false,
            bool includeFeatures = false,
            bool includeFullVehicleCheck = false)
        {
            ArgumentNullException.ThrowIfNull(vehicleRegistration);

            string url = Endpoints.VehicleData(
                advertiserId,
                vehicleRegistration,
                includeMots,
                includeFeatures,
                includeFullVehicleCheck);

            using HttpResponseMessage response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            VehicleRoot? deserialized = JsonSerializer.Deserialize<VehicleRoot>(json);

            return deserialized;
        }
    }
}
