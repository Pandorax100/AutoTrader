using System.ComponentModel.DataAnnotations;

namespace Pandorax.AutoTrader.Options;

public class AutoTraderOptions
{
    /// <summary>
    /// Gets or sets the AutoTrader API key.
    /// </summary>
    [Required]
    public string ApiKey { get; set; } = null!;

    /// <summary>
    /// Gets or sets the AutoTrader API secret.
    /// </summary>
    [Required]
    public string ApiSecret { get; set; } = null!;

    /// <summary>
    /// Gets or sets a value indicating whether to use the sandbox environment base url.
    /// </summary>
    public bool UseSandboxEnvironment { get; set; }

    /// <summary>
    /// Gets or sets the base API url to use. Note when this value is set, the value
    /// of <see cref="UseSandboxEnvironment"/> has no effect.
    /// </summary>
    public Uri? BaseApiUrl { get; set; }

    /// <summary>
    /// Gets or sets the key to use when validating notification payloads.
    /// </summary>
    public string? NotificationsValidationKey { get; set; }
}
