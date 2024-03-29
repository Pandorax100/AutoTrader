using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Pandorax.AutoTrader.Converters;

namespace Pandorax.AutoTrader.Serializer;

public class AutoTraderJsonSerializer
{
    public static readonly JsonSerializerSettings Settings = new()
    {
        ContractResolver = new AutoTraderContractResolver(),
        Converters =
        {
            new DateOnlyConverter(),
            new EmissionClassConverter(),
            new TyreConditionClassConverter(),
            new ServiceHistoryStatusConverter(),
            new LifecycleStateConverter(),
            new StatusConverter(),
            new StockEventSourceConverter(),
            new VatStatusConverter(),
            new StringEnumConverter(),
        },
    };

    public static readonly JsonSerializerSettings SettingsWithoutContractResolver = new()
    {
        Converters =
        {
            new DateOnlyConverter(),
            new EmissionClassConverter(),
            new TyreConditionClassConverter(),
            new ServiceHistoryStatusConverter(),
            new LifecycleStateConverter(),
            new StatusConverter(),
            new StockEventSourceConverter(),
            new VatStatusConverter(),
            new StringEnumConverter(),
        },
    };

    public static TValue? Deserialize<TValue>(string json)
    {
        return JsonConvert.DeserializeObject<TValue>(json, Settings);
    }

    internal static string Serialize<TValue>(TValue model)
    {
        return JsonConvert.SerializeObject(model, Settings);
    }
}
