using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class PaginatedUserList
{
    [JsonPropertyName("pagination")] public required List<Pagination> Pagination { get; set; }
    [JsonPropertyName("results")] public required List<User> Results { get; set; }
}