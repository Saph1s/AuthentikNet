using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

[JsonConverter(typeof(JsonStringEnumMemberConverter<IntentEnum>))]
public enum IntentEnum
{
    [EnumMember(Value = "verification")] Verification,
    [EnumMember(Value = "api")] Api,
    [EnumMember(Value = "recovery")] Recovery,
    [EnumMember(Value = "app_password")] AppPassword,
}