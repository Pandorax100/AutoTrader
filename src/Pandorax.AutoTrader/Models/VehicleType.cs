using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Models;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VehicleType
{
    Bike,
    Car,
    Motorhome,
    Van,
}
