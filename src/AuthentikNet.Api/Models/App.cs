using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class App
{
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("label")] public required string Label { get; set; }
}