namespace AuthentikNet.Api.Client;

/// <summary>
/// Authentik client options
/// </summary>
public class AuthentikClientOptions
{
    /// <summary>
    /// Base URL for the Authentik API
    /// </summary>
    public string BaseUrl { get; set; } = string.Empty;

    /// <summary>
    /// API token
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Timeout for the HTTP client
    /// </summary>
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(30);
}