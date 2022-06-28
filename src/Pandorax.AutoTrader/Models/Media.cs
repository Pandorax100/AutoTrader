using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;

public class Media
{
    [JsonPropertyName("images")]
    public List<Image> Images { get; set; } = null!;

    [JsonPropertyName("video")]
    public Video Video { get; set; } = null!;
}
