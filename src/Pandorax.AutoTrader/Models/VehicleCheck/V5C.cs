using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models.VehicleCheck;

public class V5C
{
    [JsonPropertyName("issuedDate")]
    public DateOnly IssuedDate { get; set; }
}
