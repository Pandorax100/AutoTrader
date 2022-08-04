using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Api.Stock.Common;

public class Advert
{
    public Advert()
    {
    }

    public Advert(Status status)
    {
        Status = status;
    }

    [JsonProperty("status")]
    public Status Status { get; set; }
}
