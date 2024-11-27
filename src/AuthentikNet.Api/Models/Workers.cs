using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Workers
{
    [JsonPropertyName("id")] public required int Id { get; set; }
}