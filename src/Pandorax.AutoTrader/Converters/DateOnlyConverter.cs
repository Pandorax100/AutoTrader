using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Converters;

internal class DateOnlyConverter : JsonConverter<DateOnly>
{
    public override DateOnly ReadJson(JsonReader reader, Type objectType, DateOnly existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        string? value = (string?)reader.Value;

        if (value is null)
        {
            throw new InvalidOperationException();
        }

        return DateOnly.Parse(value);
    }

    public override void WriteJson(JsonWriter writer, DateOnly value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }
}
