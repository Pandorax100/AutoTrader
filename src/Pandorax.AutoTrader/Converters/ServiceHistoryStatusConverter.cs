using Newtonsoft.Json;
using Pandorax.AutoTrader.Api.Stock.Common;

namespace Pandorax.AutoTrader.Converters;

internal class ServiceHistoryStatusConverter : JsonConverter<ServiceHistoryStatus?>
{
    public override ServiceHistoryStatus? ReadJson(JsonReader reader, Type objectType, ServiceHistoryStatus? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var value = (string?)reader.Value;

        if (value is null)
        {
            return null;
        }

        if (value.Equals("Full service history", StringComparison.OrdinalIgnoreCase))
        {
            return ServiceHistoryStatus.FullServiceHistory;
        }
        else if (value.Equals("Full Dealership History", StringComparison.OrdinalIgnoreCase))
        {
            return ServiceHistoryStatus.FullDealershipHistory;
        }
        else if (value.Equals("Service History", StringComparison.OrdinalIgnoreCase))
        {
            return ServiceHistoryStatus.ServiceHistory;
        }
        else if (value.Equals("Part Service History", StringComparison.OrdinalIgnoreCase))
        {
            return ServiceHistoryStatus.PartServiceHistory;
        }
        else if (value.Equals("No Service History", StringComparison.OrdinalIgnoreCase))
        {
            return ServiceHistoryStatus.NoServiceHistory;
        }

        return null;
    }

    public override void WriteJson(JsonWriter writer, ServiceHistoryStatus? value, JsonSerializer serializer)
    {
        if (value is null)
        {
            writer.WriteNull();
        }
        else
        {
            writer.WriteValue(value switch
            {
                ServiceHistoryStatus.FullServiceHistory => "Full Service History",
                ServiceHistoryStatus.FullDealershipHistory => "Full Dealership History",
                ServiceHistoryStatus.ServiceHistory => "Service History",
                ServiceHistoryStatus.PartServiceHistory => "Part Service History",
                ServiceHistoryStatus.NoServiceHistory => "No Service history",
                _ => throw new ArgumentOutOfRangeException(nameof(value)),
            });
        }
    }
}
