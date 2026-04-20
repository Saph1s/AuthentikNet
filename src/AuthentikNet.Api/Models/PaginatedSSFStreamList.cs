using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class PaginatedSSFStreamList
{
    [JsonPropertyName("pagination")] public required Pagination Pagination { get; set; }
    [JsonPropertyName("results")] public required List<SSFStream> Results { get; set; }
}