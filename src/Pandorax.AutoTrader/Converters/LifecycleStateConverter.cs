using Newtonsoft.Json;
using Pandorax.AutoTrader.Models;

namespace Pandorax.AutoTrader.Converters;

internal class LifecycleStateConverter : JsonConverter<LifecycleState>
{
    public override LifecycleState ReadJson(JsonReader reader, Type objectType, LifecycleState existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        return (string?)reader.Value switch
        {
            "DELETED" => LifecycleState.Deleted,
            "DUE_IN" => LifecycleState.DueIn,
            "FORECOURT" => LifecycleState.Forecourt,
            "SALE_IN_PROGRESS" => LifecycleState.SaleInProgress,
            "WASTEBIN" => LifecycleState.Wastebin,
            _ => throw new ArgumentException("Cannot unmarshal type LifecycleState", nameof(reader)),
        };
    }

    public override void WriteJson(JsonWriter writer, LifecycleState value, JsonSerializer serializer)
    {
        writer.WriteValue(value switch
        {
            LifecycleState.Deleted => "DELETED",
            LifecycleState.Forecourt => "FORECOURT",
            LifecycleState.SaleInProgress => "SALE_IN_PROGRESS",
            LifecycleState.Wastebin => "WASTEBIN",
            LifecycleState.DueIn => "DUE_IN",
            _ => throw new ArgumentOutOfRangeException(nameof(value)),
        });
    }
}
