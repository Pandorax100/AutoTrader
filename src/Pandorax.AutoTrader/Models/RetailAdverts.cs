using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;
public class RetailAdverts
{
    [JsonPropertyName("adminFee")]
    public Price AdminFee { get; set; } = null!;

    [JsonPropertyName("advertiserAdvert")]
    public Advert AdvertiserAdvert { get; set; } = null!;

    [JsonPropertyName("attentionGrabber")]
    public string? AttentionGrabber { get; set; }

    [JsonPropertyName("autotraderAdvert")]
    public Advert AutotraderAdvert { get; set; } = null!;

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("description2")]
    public string? Description2 { get; set; }

    [JsonPropertyName("displayOptions")]
    public DisplayOptions DisplayOptions { get; set; } = null!;

    [JsonPropertyName("exportAdvert")]
    public Advert ExportAdvert { get; set; } = null!;

    [JsonPropertyName("locatorAdvert")]
    public Advert LocatorAdvert { get; set; } = null!;

    [JsonPropertyName("manufacturerRRP")]
    public Price ManufacturerRrp { get; set; } = null!;

    [JsonPropertyName("price")]
    public Price Price { get; set; } = null!;

    [JsonPropertyName("priceIndicatorRating")]
    public PriceIndicatorRating? PriceIndicatorRating { get; set; }

    [JsonPropertyName("profileAdvert")]
    public Advert ProfileAdvert { get; set; } = null!;

    [JsonPropertyName("suppliedPrice")]
    public Price SuppliedPrice { get; set; } = null!;

    [JsonPropertyName("totalPrice")]
    public Price TotalPrice { get; set; } = null!;

    [JsonPropertyName("vatExcluded")]
    public bool? VatExcluded { get; set; }

    [JsonPropertyName("vatStatus")]
    [JsonConverter(typeof(VatStatusConverter))]
    public VatStatus? VatStatus { get; set; }
}
