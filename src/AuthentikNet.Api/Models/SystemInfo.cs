using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class SystemInfo
{
    [JsonPropertyName("http_headers")] public required Dictionary<string, string> HttpHeaders { get; init; }
    [JsonPropertyName("http_host")] public required string HttpHost { get; init; }
    [JsonPropertyName("http_is_secure")] public required bool HttpIsSecure { get; init; }
    [JsonPropertyName("runtime")] public required SystemInfoRuntime Runtime { get; init; }
    [JsonPropertyName("brand")] public required string Brand { get; init; }
    [JsonPropertyName("server_time")] public required DateTime ServerTime { get; init; }

    [JsonPropertyName("embedded_outpost_disabled")]
    public required bool EmbeddedOutpostDisabled { get; init; }

    [JsonPropertyName("embedded_outpost_host")]
    public required string EmbeddedOutpostHost { get; init; }
}