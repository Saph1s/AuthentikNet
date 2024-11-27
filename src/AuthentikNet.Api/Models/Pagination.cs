using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Pagination
{
    [JsonPropertyName("next")] public required float Next { get; set; }
    [JsonPropertyName("previous")] public required float Previous { get; set; }
    [JsonPropertyName("count")] public required float Count { get; set; }
    [JsonPropertyName("current")] public required float Current { get; set; }
    [JsonPropertyName("total_pages")] public required float TotalPages { get; set; }
    [JsonPropertyName("start_index")] public required float StartIndex { get; set; }
    [JsonPropertyName("end_index")] public required float EndIndex { get; set; }
}