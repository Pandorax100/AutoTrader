using Newtonsoft.Json;
using Pandorax.AutoTrader.Utils;

namespace Pandorax.AutoTrader.Api.Stock.Update;

public class Adverts
{
    [JsonProperty("forecourtPrice")]
    public Optional<Price> ForecourtPrice { get; set; }

    [JsonProperty("manufacturerApproved")]
    public Optional<bool?> ManufacturerApproved { get; set; }

    [JsonProperty("preparationCosts")]
    public Optional<Price> PreparationCosts { get; set; }

    [JsonProperty("priceOnApplication")]
    public Optional<bool?> PriceOnApplication { get; set; }

    [JsonProperty("purchasePrice")]
    public Optional<Price> PurchasePrice { get; set; }

    [JsonProperty("reservationStatus")]
    public Optional<string?> ReservationStatus { get; set; }

    [JsonProperty("retailAdverts")]
    public Optional<RetailAdverts> RetailAdverts { get; set; }

    [JsonProperty("soldDate")]
    public Optional<DateTime?> SoldDate { get; set; }

    [JsonProperty("stockInDate")]
    public Optional<DateTime?> StockInDate { get; set; }

    [JsonProperty("stockInValue")]
    public Optional<Price> StockInValue { get; set; }

    [JsonProperty("twelveMonthsMot")]
    public Optional<bool?> TwelveMonthsMot { get; set; }
}
