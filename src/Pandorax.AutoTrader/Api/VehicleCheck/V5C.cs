using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.VehicleCheck;

public class V5C
{
    [JsonProperty("issuedDate")]
    public DateOnly IssuedDate { get; set; }
}
