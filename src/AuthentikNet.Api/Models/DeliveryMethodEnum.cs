using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

[JsonConverter(typeof(JsonStringEnumMemberConverter<DeliveryMethodEnum>))]
public enum DeliveryMethodEnum
{
    /// <summary>
    /// PUSH
    /// </summary>
    [EnumMember(Value = "https://schemas.openid.net/secevent/risc/delivery-method/push")]
    Push,

    /// <summary>
    /// POLL
    /// </summary>
    [EnumMember(Value = "https://schemas.openid.net/secevent/risc/delivery-method/poll")]
    Poll
}