using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Pandorax.AutoTrader.Options;
using Pandorax.AutoTrader.Serializer;

namespace Pandorax.AutoTrader.Authorization
{
    internal class AccessTokenHandler
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<AccessTokenHandler> _logger;
        private readonly AutoTraderOptions _options;

        private AccessTokenJsonResponse? _accessToken;

        public AccessTokenHandler(
            HttpClient httpClient,
            IOptions<AutoTraderOptions> options,
            ILogger<AccessTokenHandler> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
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

                string responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogError("Unable to get access token. The remote returned the following error\n{Error}", responseString);
                }

                response.EnsureSuccessStatusCode();

                _accessToken = AutoTraderJsonSerializer.Deserialize<AccessTokenJsonResponse>(responseString)!;
            }

            return _accessToken.AccessToken;
        }
    }
}
