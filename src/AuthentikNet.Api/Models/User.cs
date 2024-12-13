using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

public class User
{
    [JsonPropertyName("pk")] public required int Pk { get; init; }
    [JsonPropertyName("username")] public required string Username { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_active")] public bool IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("is_superuser")] public required bool IsSuperUser { get; init; }
    [JsonPropertyName("groups")] public List<Guid> Groups { get; set; } = [];
    [JsonPropertyName("groups_obj")] public required List<UserGroup> GroupsObj { get; init; }
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
    [JsonPropertyName("avatar")] public required string Avatar { get; init; }

    [JsonPropertyName("attributes")]
    [JsonConverter(typeof(DynamicAttributesJsonConverter))]
    public object Attributes { get; set; } = new();

    [JsonPropertyName("uid")] public required string Uid { get; init; }
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;

    [JsonPropertyName("type")] public UserTypeEnum Type { get; set; }

    [JsonPropertyName("uuid")] public required Guid Uuid { get; init; }
}