using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Authorization
{
    /// <summary>
    /// Represents the authenticate response from the AutoTrader API.
    /// </summary>
    internal record AccessTokenJsonResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; init; } = null!;

        [JsonPropertyName("expires")]
        [JsonConverter(typeof(AccessTokenDateConverter))]
        public DateTimeOffset Expires { get; init; }
    }
}
