using System.Text.Json.Serialization;
using AuthentikNet.Api.Utils;

namespace AuthentikNet.Api.Models;

public class UserRequest
{
    [JsonPropertyName("username")] public required string Username { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("is_active")] public bool IsActive { get; set; }
    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }
    [JsonPropertyName("groups")] public List<Guid> Groups { get; set; } = [];
    [JsonPropertyName("email")] public string Email { get; set; } = string.Empty;

    [JsonPropertyName("attributes")]
    [JsonConverter(typeof(DynamicAttributesJsonConverter))]
    public object Attributes { get; set; } = new();

    [JsonPropertyName("path")] public string Path { get; set; } = string.Empty;
    [JsonPropertyName("type")] public UserTypeEnum Type { get; set; }

    /// <summary>
    /// UserRequest constructor
    /// </summary>
    public UserRequest()
    {
    }

    /// <summary>
    /// UserRequest constructor with username and name
    /// </summary>
    /// <param name="username"></param>
    /// <param name="name"></param>
    public UserRequest(string username, string name)
    {
        Username = username;
        Name = name;
    }
}