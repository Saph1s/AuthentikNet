using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

[JsonConverter(typeof(JsonStringEnumMemberConverter<EventsRequestedEnum>))]
public enum EventsRequestedEnum
{
    [EnumMember(Value = "https://schemas.openid.net/secevent/caep/event-type/session-revoked")]
    CAEP_EVENT_TYPE_SESSION_REVOKED,

    [EnumMember(Value = "https://schemas.openid.net/secevent/caep/event-type/credential-change")]
    CAEP_EVENT_TYPE_CREDENTIAL_CHANGE,

    [EnumMember(Value = "https://schemas.openid.net/secevent/ssf/event-type/verification")]
    SSF_EVENT_TYPE_VERIFICATION
}