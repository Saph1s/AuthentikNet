using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class SSFStream
{
    [JsonPropertyName("pk")] public required Guid Pk { get; init; }
    [JsonPropertyName("provider")] public required int Provider { get; set; }
    [JsonPropertyName("provider_obj")] public required SSFProvider ProviderObj { get; init; }
    [JsonPropertyName("delivery_method")] public required DeliveryMethodEnum DeliveryMethod { get; set; }
    [JsonPropertyName("endpoint_url")] public string? EndpointUrl { get; set; }
    [JsonPropertyName("events_requested")] public List<EventsRequestedEnum>? EventsRequested { get; set; }
    [JsonPropertyName("format")] public required string Format { get; set; }
    [JsonPropertyName("aud")] public List<string>? Aud { get; init; }
    [JsonPropertyName("iss")] public required string Iss { get; set; }
}