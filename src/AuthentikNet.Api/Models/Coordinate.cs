using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Coordinate
{
    [JsonPropertyName("x_cord")] public required int XCord { get; init; }
    [JsonPropertyName("y_cord")] public required int YCord { get; init; }
}