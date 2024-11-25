using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

/// <summary>
/// The type of account
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
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