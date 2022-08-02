using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Pandorax.AutoTrader.Models;
using Pandorax.AutoTrader.Models.Images;
using Pandorax.AutoTrader.Models.Stock;
using Pandorax.AutoTrader.Models.Vehicles;
using Pandorax.AutoTrader.Serializer;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader
{
    internal class AutoTraderService : IAutoTraderService
    {
        private readonly HttpClient _client;

        public AutoTraderService(HttpClient client)
        {
            _client = client;
        }

        public AutoTraderNotification? ParseNotificationJson(string json)
        {
            return AutoTraderJsonSerializer.Deserialize<AutoTraderNotification>(json);
        }

        /// <inheritdoc />
        public async Task<StockListResult?> GetStockAsync(StockSearchParameters parameters)
        {
            string url = Endpoints.SearchEndpoint(parameters);

            StockListResult? parsed = await _client.GetFromJsonAsync<StockListResult>(url, AutoTraderJsonSerializer.Options);

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

        public async Task<CreateStockResponse> CreateStockAsync(int advertiserId, AutoTraderVehicleData vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle);

            string json = JsonSerializer.Serialize(vehicle, AutoTraderJsonSerializer.OptionsNoWriteNull);

            string url = Endpoints.CreateStockEndpoint(advertiserId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseBody = await response.Content.ReadAsStringAsync();

            AutoTraderVehicleData? deserialised = await response.Content.ReadFromJsonAsync<AutoTraderVehicleData>(AutoTraderJsonSerializer.Options);

            return new CreateStockResponse
            {
                Success = response.IsSuccessStatusCode,
                Messages = deserialised?.Messages ?? new List<AutoTraderMessage>(),
                AutoTraderVehicleData = deserialised,
            };
        }

        public async Task<UpdateStockResponse> UpdateStockAsync(string stockId, AutoTraderVehicleData vehicle)
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

            var deserialized = await response.Content.ReadFromJsonAsync<AutoTraderVehicleData>(AutoTraderJsonSerializer.Options);

            return new UpdateStockResponse
            {
                Success = response.IsSuccessStatusCode,
                Messages = deserialized?.Messages ?? new List<AutoTraderMessage>(),
                AutoTraderVehicleData = deserialized,
            };
        }

        public async Task<AutoTraderVehicleData> RemoveStockItemAsync(string stockId)
        {
            ArgumentNullException.ThrowIfNull(stockId);

            var payload = new AutoTraderVehicleData
            {
                Metadata = new Metadata
                {
                    LifecycleState = LifecycleState.Deleted,
                },
                Adverts = new Adverts
                {
                    RetailAdverts = new RetailAdverts
                    {
                        AdvertiserAdvert = new Advert(Status.NotPublished),
                        AutotraderAdvert = new Advert(Status.NotPublished),
                        ExportAdvert = new Advert(Status.NotPublished),
                        LocatorAdvert = new Advert(Status.NotPublished),
                        ProfileAdvert = new Advert(Status.NotPublished),
                    },
                },
            };

            string json = JsonSerializer.Serialize(payload, AutoTraderJsonSerializer.OptionsNoWriteNull);
            string url = Endpoints.UpdateStockEndpoint(stockId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseJson = await response.Content.ReadAsStringAsync();

            AutoTraderVehicleData? deserialized = AutoTraderJsonSerializer.Deserialize<AutoTraderVehicleData>(responseJson);

            return deserialized!;
        }

        public async Task<UploadImageResponse> UploadImageAsync(int advertiserId, Stream stream, string contentType, string fileName)
        {
            using var streamContent = new StreamContent(stream);
            using var multipartFormContent = new MultipartFormDataContent();

            var content = new StreamContent(stream);
            content.Headers.ContentType = new MediaTypeHeaderValue(contentType);

            multipartFormContent.Add(content, "file", fileName);

            using HttpResponseMessage response = await _client.PostAsync(Endpoints.UploadImage(advertiserId), multipartFormContent);

            response.EnsureSuccessStatusCode();

            UploadImageResponse? responseDeserialized = await response.Content.ReadFromJsonAsync<UploadImageResponse>();

            return responseDeserialized!;
        }

        public async Task<VehicleRoot?> GetVehicleDataAsync(
            int advertiserId,
            string vehicleRegistration,
            bool includeMots = false,
            bool includeFeatures = false,
            bool includeBasicVehicleCheck = false,
            bool includeFullVehicleCheck = false)
        {
            ArgumentNullException.ThrowIfNull(vehicleRegistration);

            string url = Endpoints.VehicleData(
                advertiserId,
                vehicleRegistration,
                includeMots,
                includeFeatures,
                includeBasicVehicleCheck,
                includeFullVehicleCheck);

            using HttpResponseMessage response = await _client.GetAsync(url);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            VehicleRoot? deserialized = AutoTraderJsonSerializer.Deserialize<VehicleRoot>(json);

            return deserialized;
        }
    }
}
