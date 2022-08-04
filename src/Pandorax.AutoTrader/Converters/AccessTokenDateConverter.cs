using System.Globalization;
using Newtonsoft.Json;

namespace Pandorax.AutoTrader.Converters
{
    /// <summary>
    /// A converter for dates in the format "Wed May 18 09:35:06 UTC 2022".
    /// </summary>
    internal class AccessTokenDateConverter : JsonConverter<DateTimeOffset>
    {
        public override DateTimeOffset ReadJson(
            JsonReader reader,
            Type objectType,
            DateTimeOffset existingValue,
            bool hasExistingValue,
            JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            var dateTime = DateTimeOffset.ParseExact(
                (string?)reader.Value!,
                @"ddd MMM dd HH:mm:ss \U\T\C yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.AssumeUniversal);

            return dateTime;
        }

        public override void WriteJson(JsonWriter writer, DateTimeOffset value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
