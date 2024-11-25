using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class UserRequest
{
    [JsonPropertyName("username")] public required string Username { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_active")] public bool IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("groups")] public List<Guid> Groups { get; set; } = [];
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
    [JsonPropertyName("attributes")] public Dictionary<string, string> Attributes { get; set; } = new();
    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("type")] public UserTypeEnum Type { get; set; }
}