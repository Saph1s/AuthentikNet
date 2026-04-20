using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

/// <summary>
/// User account type
/// </summary>
[JsonConverter(typeof(JsonStringEnumMemberConverter<UserTypeEnum>))]
public enum UserTypeEnum
{
    /// <summary>
    /// Internal
    /// </summary>
    [EnumMember(Value = "internal")] Internal,

    /// <summary>
    /// External
    /// </summary>
    [EnumMember(Value = "external")] External,

    /// <summary>
    /// Service account
    /// </summary>
    [EnumMember(Value = "service_account")]
    ServiceAccount,

    /// <summary>
    /// Internal service account
    /// </summary>
    [EnumMember(Value = "internal_service_account")]
    InternalServiceAccount
}