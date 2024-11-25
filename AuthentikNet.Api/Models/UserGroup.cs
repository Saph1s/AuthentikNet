using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class UserGroup
{
    [JsonPropertyName("pk")] public required Guid Pk { get; init; }
    [JsonPropertyName("num_pk")] public required int NumPk { get; init; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_superuser")] public bool IsSuperUser { get; set; }
    [JsonPropertyName("parent")] public Guid? Parent { get; init; }
    [JsonPropertyName("parent_name")] public required string? ParentName { get; init; }
    [JsonPropertyName("attributes")] public Dictionary<string, string> Attributes { get; set; } = new();
}