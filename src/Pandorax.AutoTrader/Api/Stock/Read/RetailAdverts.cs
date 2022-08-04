using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Api.Stock.Read;

public class RetailAdverts
{
    [JsonProperty("adminFee")]
    public Price AdminFee { get; set; } = null!;

    [JsonProperty("advertiserAdvert")]
    public Advert AdvertiserAdvert { get; set; } = null!;

    [JsonProperty("attentionGrabber")]
    public string? AttentionGrabber { get; set; }

    [JsonProperty("autotraderAdvert")]
    public Advert AutotraderAdvert { get; set; } = null!;

    [JsonProperty("description")]
    public string? Description { get; set; }

    [JsonProperty("description2")]
    public string? Description2 { get; set; }

    [JsonProperty("displayOptions")]
    public DisplayOptions DisplayOptions { get; set; } = null!;

    [JsonProperty("exportAdvert")]
    public Advert ExportAdvert { get; set; } = null!;

    [JsonProperty("locatorAdvert")]
    public Advert LocatorAdvert { get; set; } = null!;

    [JsonProperty("manufacturerRRP")]
    public Price ManufacturerRrp { get; set; } = null!;

    [JsonProperty("price")]
    public Price Price { get; set; } = null!;

    [JsonProperty("priceIndicatorRating")]
    public PriceIndicatorRating? PriceIndicatorRating { get; set; }

    [JsonProperty("profileAdvert")]
    public Advert ProfileAdvert { get; set; } = null!;

    [JsonProperty("suppliedPrice")]
    public Price SuppliedPrice { get; set; } = null!;

    [JsonProperty("totalPrice")]
    public Price TotalPrice { get; set; } = null!;

    [JsonProperty("vatExcluded")]
    public bool? VatExcluded { get; set; }

    [JsonProperty("vatStatus")]
    [JsonConverter(typeof(VatStatusConverter))]
    public VatStatus? VatStatus { get; set; }
}
