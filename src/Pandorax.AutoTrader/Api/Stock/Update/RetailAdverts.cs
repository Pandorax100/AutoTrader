using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class RetailAdverts
{
    [JsonProperty("adminFee")]
    public Optional<Price> AdminFee { get; set; }

    [JsonProperty("advertiserAdvert")]
    public Optional<Advert> AdvertiserAdvert { get; set; }

    [JsonProperty("attentionGrabber")]
    public Optional<string?> AttentionGrabber { get; set; }

    [JsonProperty("autotraderAdvert")]
    public Optional<Advert> AutotraderAdvert { get; set; }

    [JsonProperty("description")]
    public Optional<string?> Description { get; set; }

    [JsonProperty("description2")]
    public Optional<string?> Description2 { get; set; }

    [JsonProperty("displayOptions")]
    public Optional<DisplayOptions> DisplayOptions { get; set; }

    [JsonProperty("exportAdvert")]
    public Optional<Advert> ExportAdvert { get; set; }

    [JsonProperty("locatorAdvert")]
    public Optional<Advert> LocatorAdvert { get; set; }

    [JsonProperty("manufacturerRRP")]
    public Optional<Price> ManufacturerRrp { get; set; }

    [JsonProperty("price")]
    public Optional<Price> Price { get; set; }

    [JsonProperty("priceIndicatorRating")]
    public Optional<PriceIndicatorRating?> PriceIndicatorRating { get; set; }

    [JsonProperty("profileAdvert")]
    public Optional<Advert> ProfileAdvert { get; set; }

    [JsonProperty("suppliedPrice")]
    public Optional<Price> SuppliedPrice { get; set; }

    [JsonProperty("totalPrice")]
    public Optional<Price> TotalPrice { get; set; }

    [JsonProperty("vatExcluded")]
    public Optional<bool?> VatExcluded { get; set; }

    [JsonProperty("vatStatus")]
    public Optional<VatStatus?> VatStatus { get; set; }
}
