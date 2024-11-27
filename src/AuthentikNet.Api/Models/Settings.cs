using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

public class Settings
{
    [JsonPropertyName("avatars")] public string Avatars { get; set; } = string.Empty;

    [JsonPropertyName("default_user_change_name")]
    public bool DefaultUserChangeName { get; set; }

    [JsonPropertyName("default_user_change_email")]
    public bool DefaultUserChangeEmail { get; set; }

    [JsonPropertyName("default_user_change_username")]
    public bool DefaultUserChangeUsername { get; set; }

    [JsonPropertyName("event_retention")] public string EventRetention { get; set; } = string.Empty;
    [JsonPropertyName("footer_links")] public List<(string href, string name)> FooterLinks { get; set; }
    [JsonPropertyName("gdpr_compliance")] public bool GdprCompliance { get; set; }
    [JsonPropertyName("impersonation")] public bool Impersonation { get; set; }

    [JsonPropertyName("impersonation_require_reason")]
    public bool ImpersonationRequireReason { get; set; }

    [JsonPropertyName("default_token_duration")]
    public string DefaultTokenDuration { get; set; } = string.Empty;

    [JsonPropertyName("default_token_length")]
    public int DefaultTokenLength { get; set; }
}