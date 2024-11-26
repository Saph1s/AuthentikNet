using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class SystemInfoRuntime
{
    [JsonPropertyName("python_version")] public required string PythonVersion { get; set; }
    [JsonPropertyName("environment")] public required string Environment { get; set; }
    [JsonPropertyName("architecture")] public required string Architecture { get; set; }
    [JsonPropertyName("platform")] public required string Platform { get; set; }
    [JsonPropertyName("uname")] public required string Uname { get; set; }
    [JsonPropertyName("openssl_version")] public required string OpensslVersion { get; set; }

    [JsonPropertyName("openssl_fips_enabled")]
    public required bool? OpensslFipsEnabled { get; set; }

    [JsonPropertyName("authentik_version")]
    public required string AuthentikVersion { get; set; }
}