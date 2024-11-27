using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Version
{
    [JsonPropertyName("version_current")] public required string VersionCurrent { get; init; }
    [JsonPropertyName("version_latest")] public required string VersionLatest { get; init; }

    [JsonPropertyName("version_latest_valid")]
    public required bool VersionLatestValid { get; init; }

    [JsonPropertyName("build_hash")] public required string BuildHash { get; init; }
    [JsonPropertyName("outdated")] public required bool Outdated { get; init; }
    [JsonPropertyName("outpost_outdated")] public required bool OutpostOutdated { get; init; }
}