using System.Text.Json.Serialization;

namespace AuthentikNet.Api.Models;

/// <summary>
/// Settings PATCH request
/// </summary>
public class PatchedSettingsRequest
{
    private int? _defaultTokenLength;

    /// <summary>
    /// Configure how authentik should show avatars for users.
    /// </summary>
    [JsonPropertyName("avatars")]
    public string? Avatars { get; set; }

    /// <summary>
    /// Enable the ability for users to change their name.
    /// </summary>
    [JsonPropertyName("default_user_change_name")]
    public bool? DefaultUserChangeName { get; set; }

    /// <summary>
    /// Enable the ability for users to change their email address.
    /// </summary>
    [JsonPropertyName("default_user_change_email")]
    public bool? DefaultUserChangeEmail { get; set; }

    /// <summary>
    /// Enable the ability for users to change their username.
    /// </summary>
    [JsonPropertyName("default_user_change_username")]
    public bool? DefaultUserChangeUsername { get; set; }

    /// <summary>
    /// Events will be deleted after this duration.(Format: weeks=3;days=2;hours=3,seconds=2).
    /// </summary>
    [JsonPropertyName("event_retention")]
    public string? EventRetention { get; set; }

    /// <summary>
    /// Reputation cannot decrease lower than this value. Zero or negative.
    /// </summary>
    [JsonPropertyName("reputation_lower_limit")]
    public int? ReputationLowerLimit { get; set; }

    /// <summary>
    /// Reputation cannot increase higher than this value. Zero or positive.
    /// </summary>
    [JsonPropertyName("reputation_upper_limit")]
    public int? ReputationUpperLimit { get; set; }

    /// <summary>
    /// The option configures the footer links on the flow executor pages.
    /// </summary>
    [JsonPropertyName("footer_links")]
    public List<(string href, string name)>? FooterLinks { get; set; } = [];

    /// <summary>
    /// When enabled, all the events caused by a user will be deleted upon the user's deletion.
    /// </summary>
    [JsonPropertyName("gdpr_compliance")]
    public bool? GdprCompliance { get; set; }

    /// <summary>
    /// Globally enable/disable impersonation.
    /// </summary>
    [JsonPropertyName("impersonation")]
    public bool? Impersonation { get; set; }

    /// <summary>
    /// Require administrators to provide a reason for impersonating a user.
    /// </summary>
    [JsonPropertyName("impersonation_require_reason")]
    public bool? ImpersonationRequireReason { get; set; }

    /// <summary>
    /// Default token duration
    /// </summary>
    [JsonPropertyName("default_token_duration")]
    public string? DefaultTokenDuration { get; set; }

    /// <summary>
    /// Default token length
    /// </summary>
    [JsonPropertyName("default_token_length")]
    public int? DefaultTokenLength
    {
        get => _defaultTokenLength;
        set
        {
            if (value < 1)
                throw new ArgumentOutOfRangeException(nameof(DefaultTokenLength),
                    "Value must be greater or equal to 1 and less or equal to 2147483647");

            _defaultTokenLength = value;
        }
    }

    /// <summary>
    /// PatchedSettingsRequest constructor
    /// </summary>
    public PatchedSettingsRequest()
    {
    }
}