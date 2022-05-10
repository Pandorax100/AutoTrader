using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
public class Advert
{
    [JsonPropertyName("status")]
    public Status Status { get; set; }
}
