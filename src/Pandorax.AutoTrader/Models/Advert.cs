using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class Advert
{
    public Advert()
    {
    }

    public Advert(Status status)
    {
        Status = status;
    }

    [JsonPropertyName("status")]
    public Status Status { get; set; }
}
