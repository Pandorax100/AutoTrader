using Newtonsoft.Json;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Authorization
{
    /// <summary>
    /// Represents the authenticate response from the AutoTrader API.
    /// </summary>
    internal record AccessTokenJsonResponse
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; init; } = null!;

        [JsonProperty("expires")]
        [JsonConverter(typeof(AccessTokenDateConverter))]
        public DateTimeOffset Expires { get; init; }
    }
}
