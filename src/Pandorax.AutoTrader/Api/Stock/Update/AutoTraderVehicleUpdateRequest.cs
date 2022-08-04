using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class AutoTraderVehicleUpdateRequest
{
    [JsonProperty("adverts")]
    public Optional<Adverts?> Adverts { get; set; }

    [JsonProperty("features")]
    public Optional<List<Feature>> Features { get; set; }

    [JsonProperty("media")]
    public Optional<Media?> Media { get; set; }

    [JsonProperty("metadata")]
    public Optional<Metadata?> Metadata { get; set; }

    [JsonProperty("vehicle")]
    public Optional<Vehicle?> Vehicle { get; set; }
}
