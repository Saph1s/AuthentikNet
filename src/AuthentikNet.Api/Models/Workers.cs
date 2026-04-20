using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Workers
{
    [JsonPropertyName("worker_id")] public required int WorkerId { get; set; }
    [JsonPropertyName("version")] public required string Version { get; set; }
    [JsonPropertyName("version_matching")] public required bool VersionMatching { get; set; }
}