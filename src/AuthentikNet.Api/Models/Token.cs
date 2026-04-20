using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Token
{
    [JsonPropertyName("pk")] public required Guid Pk { get; init; }
    [JsonPropertyName("managed")] public string? Managed { get; set; }
    [JsonPropertyName("identifier")] public required string Identifier { get; set; }
    [JsonPropertyName("intent")] public IntentEnum? Intent { get; set; }
    [JsonPropertyName("user")] public int? User { get; set; }
    [JsonPropertyName("user_obj")] public required User UserObj { get; init; }
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("expires")] public DateTime? Expires { get; set; }
    [JsonPropertyName("expiring")] public bool? Expiring { get; set; }
}