using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Converters;

internal class DateOnlyConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(DateOnly) || objectType == typeof(DateOnly?);
    }

    public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
    {
        string? value = (string?)reader.Value;

        return value is null ? null : DateOnly.Parse(value);
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
