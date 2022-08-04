using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using Newtonsoft.Json;
using Pandorax.AutoTrader.Models;
using Pandorax.AutoTrader.Models.Images;
using Pandorax.AutoTrader.Models.Stock;
using Pandorax.AutoTrader.Models.UpdateStock;
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

            string responseJson = await _client.GetStringAsync(url);

            StockListResult? result = AutoTraderJsonSerializer.Deserialize<StockListResult>(responseJson);

            return result;
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

            string json = AutoTraderJsonSerializer.Serialize(vehicle);

            string url = Endpoints.CreateStockEndpoint(advertiserId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseBody = await response.Content.ReadAsStringAsync();

            AutoTraderVehicleData? deserialised = AutoTraderJsonSerializer.Deserialize<AutoTraderVehicleData>(responseBody);

            return new CreateStockResponse
            {
                Success = response.IsSuccessStatusCode,
                Messages = deserialised?.Messages ?? new List<AutoTraderMessage>(),
                AutoTraderVehicleData = deserialised,
            };
        }

        public async Task<UpdateStockResponse> UpdateStockAsync(string stockId, UpdateAutoTraderVehicleData vehicle)
        {
            ArgumentNullException.ThrowIfNull(vehicle);
            ArgumentNullException.ThrowIfNull(stockId);

            string requestJson = AutoTraderJsonSerializer.Serialize(vehicle);

            string url = Endpoints.UpdateStockEndpoint(stockId);

            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Patch, url)
            {
                Content = new StringContent(requestJson, Encoding.UTF8, "application/json"),
            };

            using HttpResponseMessage response = await _client.SendAsync(request);

            var responseJson = await response.Content.ReadAsStringAsync();

            var deserialized = AutoTraderJsonSerializer.Deserialize<AutoTraderVehicleData>(responseJson);

            return new UpdateStockResponse
            {
                Success = response.IsSuccessStatusCode,
                Messages = deserialized?.Messages ?? new List<AutoTraderMessage>(),
                AutoTraderVehicleData = deserialized,
            };
        }

        public async Task<UpdateStockResponse> RemoveStockItemAsync(string stockId)
        {
            ArgumentNullException.ThrowIfNull(stockId);

            var payload = new UpdateAutoTraderVehicleData
            {
                Metadata = new Models.UpdateStock.Metadata
                {
                    LifecycleState = LifecycleState.Deleted,
                },
                Adverts = new Models.UpdateStock.Adverts
                {
                    RetailAdverts = new Models.UpdateStock.RetailAdverts
                    {
                        AdvertiserAdvert = new Advert(Status.NotPublished),
                        AutotraderAdvert = new Advert(Status.NotPublished),
                        ExportAdvert = new Advert(Status.NotPublished),
                        LocatorAdvert = new Advert(Status.NotPublished),
                        ProfileAdvert = new Advert(Status.NotPublished),
                    },
                },
            };

            return await UpdateStockAsync(stockId, payload);
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
