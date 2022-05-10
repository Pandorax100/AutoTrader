using System.Text.Json.Serialization;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(FuelTypeConverter))]
public enum FuelType
{
    Diesel,
    DieselPlugInHybrid,
    Electric,
    Petrol,
    PetrolHybrid,
    PetrolPlugInHybrid,
    Unlisted,
}
