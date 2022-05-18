using System.Text.Json;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Options;

namespace Pandorax.AutoTrader.Services
{
    internal class AccessTokenHandler
    {
        private readonly HttpClient _httpClient;
        private readonly AutoTraderOptions _options;

        private AccessTokenJsonResponse? _accessToken;

        public AccessTokenHandler(
            HttpClient httpClient,
            IOptions<AutoTraderOptions> options)
        {
            _httpClient = httpClient;
            _options = options.Value;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            if (_accessToken is null || _accessToken.Expires < DateTimeOffset.Now)
            {
                using FormUrlEncodedContent body = new(new Dictionary<string, string>
                {
                    ["key"] = _options.ApiKey,
                    ["secret"] = _options.ApiSecret,
                });

                using HttpResponseMessage? response = await _httpClient.PostAsync("/authenticate", body);

                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();

                _accessToken = JsonSerializer.Deserialize<AccessTokenJsonResponse>(json)!;
            }

            return _accessToken.AccessToken;
        }
    }
}
