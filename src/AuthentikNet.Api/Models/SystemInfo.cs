using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class SystemInfo
{
    /// <summary>
    /// Get HTTP Request headers
    /// </summary>
    [JsonPropertyName("http_headers")]
    public required Dictionary<string, string> HttpHeaders { get; init; }

    /// <summary>
    /// Get HTTP host
    /// </summary>
    [JsonPropertyName("http_host")]
    public required string HttpHost { get; init; }

    /// <summary>
    /// Get HTTP Secure flag
    /// </summary>
    [JsonPropertyName("http_is_secure")]
    public required bool HttpIsSecure { get; init; }

    /// <summary>
    /// Get versions
    /// </summary>
    [JsonPropertyName("runtime")]
    public required SystemInfoRuntime Runtime { get; init; }

    /// <summary>
    /// Currently active brand
    /// </summary>
    [JsonPropertyName("brand")]
    public required string Brand { get; init; }

    /// <summary>
    /// Current server time
    /// </summary>
    [JsonPropertyName("server_time")]
    public required DateTime ServerTime { get; init; }

    /// <summary>
    /// Whether the embedded outpost is disabled
    /// </summary>
    [JsonPropertyName("embedded_outpost_disabled")]
    public required bool EmbeddedOutpostDisabled { get; init; }

    /// <summary>
    /// Get the FQDN configured on the embedded outpost
    /// </summary>
    [JsonPropertyName("embedded_outpost_host")]
    public required string EmbeddedOutpostHost { get; init; }
}