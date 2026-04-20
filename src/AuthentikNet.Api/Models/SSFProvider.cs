using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class SSFProvider
{
    [JsonPropertyName("pk")] public required int Pk { get; init; }
    [JsonPropertyName("name")] public required string Name { get; set; }

    /// <summary>
    /// Get object component so that we know how to edit the object	
    /// </summary>
    [JsonPropertyName("component")]
    public required string Component { get; init; }

    /// <summary>
    /// Return object's verbose_name
    /// </summary>
    [JsonPropertyName("verbose_name")]
    public required string VerboseName { get; init; }

    /// <summary>
    /// Return object's plural verbose_name
    /// </summary>
    [JsonPropertyName("verbose_name_plural")]
    public required string VerboseNamePlural { get; init; }

    /// <summary>
    /// Return internal model name
    /// </summary>
    [JsonPropertyName("meta_model_name")]
    public required string MetaModelName { get; init; }

    /// <summary>
    /// Key used to sign the SSF Events.
    /// </summary>
    [JsonPropertyName("signing_key")]
    public required Guid SigningKey { get; init; }

    [JsonPropertyName("token_obj")] public required Token TokenObj { get; init; }

    [JsonPropertyName("oidc_auth_providers")]
    public List<int>? OidcAuthProviders { get; set; }

    [JsonPropertyName("ssf_url")] public required string? SSFUrl { get; init; }
    [JsonPropertyName("event_retention")] public string? EventRetention { get; set; }
}