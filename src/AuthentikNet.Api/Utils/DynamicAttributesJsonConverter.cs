using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Utils;

public class DynamicAttributesJsonConverter : JsonConverter<object>
{
    public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return ParseValue(ref reader, options);
    }

    private static object? ParseValue(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.StartObject => ParseObject(ref reader, options),
            JsonTokenType.StartArray => ParseArray(ref reader, options),
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number => reader.TryGetInt64(out var l) ? l : reader.GetDouble(),
            JsonTokenType.True => true,
            JsonTokenType.False => false,
            JsonTokenType.Null => null,
            _ => throw new JsonException($"Unsupported JSON token: {reader.TokenType}")
        };
    }

    private static Dictionary<string, object?> ParseObject(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        var dictionary = new Dictionary<string, object?>();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndObject)
                break;

            if (reader.TokenType != JsonTokenType.PropertyName)
                throw new JsonException("Expected a property name.");

            var propertyName = reader.GetString();
            reader.Read();

            var value = ParseValue(ref reader, options);
            dictionary[propertyName!] = value;
        }

        return dictionary;
    }

    private static List<object?> ParseArray(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
        var list = new List<object?>();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
                break;

            var value = ParseValue(ref reader, options);
            list.Add(value);
        }

        return list;
    }

    public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}