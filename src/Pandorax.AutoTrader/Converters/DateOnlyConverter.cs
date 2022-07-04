using System.Text.Json;
using System.Text.Json.Serialization;

namespace Pandorax.AutoTrader.Converters;

internal class DateOnlyConverter : JsonConverter<DateOnly>
{
    public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();

        if (value is null)
        {
            throw new InvalidOperationException();
        }

        return DateOnly.Parse(value);
    }

    public override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
