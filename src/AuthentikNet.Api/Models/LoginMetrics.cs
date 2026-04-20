using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class LoginMetrics
{
    [JsonPropertyName("logins")] public required List<Coordinate> Logins { get; init; }
    [JsonPropertyName("logins_failed")] public required List<Coordinate> LoginsFailed { get; init; }
    [JsonPropertyName("authorizations")] public required List<Coordinate> Authorizations { get; init; }
}