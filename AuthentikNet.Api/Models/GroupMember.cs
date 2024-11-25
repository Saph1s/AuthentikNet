using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class GroupMember
{
    [JsonPropertyName("pk")] public required int Pk { get; init; }

    [JsonPropertyName("username")]
    [MaxLength(150)] // TODO: Regex
    public required string Username { get; set; }

    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_active")] public bool IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;
    [JsonPropertyName("attributes")] public Dictionary<string, string> Attributes { get; set; } = new();
    [JsonPropertyName("uid")] public required string Uid { get; init; }
}