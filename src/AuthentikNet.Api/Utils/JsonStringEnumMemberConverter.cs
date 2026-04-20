using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Utils;

/// <summary>
/// Universal JSON converter for Enums with EnumMember attributes.
/// </summary>
public class JsonStringEnumMemberConverter<T> : JsonConverter<T> where T : struct, Enum
{
    /// <inheritdoc />
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        foreach (var field in typeof(T).GetFields())
        {
            var attr = field.GetCustomAttribute<EnumMemberAttribute>();
            if (attr != null && attr.Value == value)
                return (T)field.GetValue(null)!;
        }

        return Enum.Parse<T>(value!);
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var field = typeof(T).GetField(value.ToString());
        var attr = field?.GetCustomAttribute<EnumMemberAttribute>();
        writer.WriteStringValue(attr?.Value ?? value.ToString());
    }
}