using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

public class PatchedUserRequest
{
    [JsonPropertyName("username")] public string? Username { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("is_active")] public bool? IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("groups")] public List<Guid>? Groups { get; set; }
    [JsonPropertyName("email")] public string? Email { get; set; }

    [JsonPropertyName("attributes")]
    [JsonConverter(typeof(DynamicAttributesJsonConverter))]
    public object? Attributes { get; set; }

    [JsonPropertyName("path")] public string? Path { get; set; }
    [JsonPropertyName("type")] public UserTypeEnum? Type { get; set; }
}