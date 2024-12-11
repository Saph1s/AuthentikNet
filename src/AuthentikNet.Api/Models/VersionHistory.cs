using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class VersionHistory
{
    [JsonPropertyName("id")] public required int Id { get; init; }
    [JsonPropertyName("timestamp")] public required DateTime Timestamp { get; set; }
    [JsonPropertyName("version")] public required string Version { get; set; }
    [JsonPropertyName("build")] public required string Build { get; set; }
}