using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Role
{
    [JsonPropertyName("pk")] public required int Pk { get; init; }
    [JsonPropertyName("name")] public required string Name { get; set; }
}