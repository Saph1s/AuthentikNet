using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Version
{
    /// <summary>
    /// Get current version
    /// </summary>
    [JsonPropertyName("version_current")]
    public required string VersionCurrent { get; init; }

    /// <summary>
    /// Get latest version from cache
    /// </summary>
    [JsonPropertyName("version_latest")]
    public required string VersionLatest { get; init; }

    /// <summary>
    /// Check if latest version is valid
    /// </summary>
    [JsonPropertyName("version_latest_valid")]
    public required bool VersionLatestValid { get; init; }

    /// <summary>
    /// Get build hash, if version is not latest or released
    /// </summary>
    [JsonPropertyName("build_hash")]
    public required string BuildHash { get; init; }

    /// <summary>
    /// Check if we're running the latest version
    /// </summary>
    [JsonPropertyName("outdated")]
    public required bool Outdated { get; init; }

    /// <summary>
    /// Check if any outpost is outdated/has a version mismatch
    /// </summary>
    [JsonPropertyName("outpost_outdated")]
    public required bool OutpostOutdated { get; init; }
}