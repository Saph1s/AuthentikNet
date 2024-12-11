using System.Text.Json;
using System.Text.Json.Serialization;
using AuthentikNet.Api.Models;

namespace AuthentikNet.Api.Utils;

public class UserTypeEnumConverter : JsonConverter<UserTypeEnum>
{
    public override UserTypeEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString();
        return value switch
        {
            "internal" => UserTypeEnum.Internal,
            "external" => UserTypeEnum.External,
            "service_account" => UserTypeEnum.ServiceAccount,
            "internal_service_account" => UserTypeEnum.InternalServiceAccount,
            _ => throw new JsonException($"Unknown value: {value}")
        };
    }

    public override void Write(Utf8JsonWriter writer, UserTypeEnum value, JsonSerializerOptions options)
    {
        var stringValue = value switch
        {
            UserTypeEnum.Internal => "internal",
            UserTypeEnum.External => "external",
            UserTypeEnum.ServiceAccount => "service_account",
            UserTypeEnum.InternalServiceAccount => "internal_service_account",
            _ => throw new JsonException($"Unknown value: {value}")
        };
        writer.WriteStringValue(stringValue);
    }
}