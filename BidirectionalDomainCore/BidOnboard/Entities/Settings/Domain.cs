namespace Bidirectional.DomainCore.BidOnboard.Entities.Settings;

/// <summary>
/// Represents the configuration for a CORS policy domain, including allowed origins, methods, headers, and other CORS-related settings.
/// </summary>
public class Domain : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets a friendly name for the CORS policy, such as "AllowAll" or "RestrictivePolicy".
    /// </summary>
    [Comment("A friendly name for the CORS policy, like \"AllowAll\" or \"RestrictivePolicy\". This can help you identify the policy in the system")]
    public required string CorsPolicyName { get; set; }

    /// <summary>
    /// Gets or sets a comma-separated list of allowed origins for the CORS policy.
    /// </summary>
    [Comment("A comma-separated list of allowed origins. E.g., \"https://example.com, https://anotherdomain.com\". You can also consider storing this as a JSON array if you expect to have multiple origins per configuration")]
    public required string AllowedOrigin { get; set; }

    /// <summary>
    /// Gets or sets a comma-separated list of allowed HTTP methods (e.g., GET, POST, PUT, PATCH, DELETE).
    /// </summary>
    [Comment("A comma-separated list of allowed HTTP methods (e.g., GET, POST, PUT, PATCH, DELETE)")]
    public string? AllowedHttpMethods { get; set; }

    /// <summary>
    /// Gets or sets a comma-separated list of allowed HTTP headers for CORS requests.
    /// </summary>
    [Comment("A comma-separated list of allowed HTTP headers. For example, \"Content-Type, Authorization\". This defines which headers are allowed in the actual request.")]
    public string? AllowedRequestHeaders { get; set; }

    /// <summary>
    /// Gets or sets a comma-separated list of headers that are safe to expose to the client.
    /// </summary>
    [Comment("A comma-separated list of headers that are safe to expose to the client (e.g., Authorization, X-My-Custom-Header)")]
    public string? ExposedResponseHeaders { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating whether credentials should be allowed in CORS requests.
    /// </summary>
    [Comment("Whether the browser should include credentials (cookies, HTTP authentication, and client-side SSL certificates) with requests. Default is false.")]
    public string? AllowCredentialsFlag { get; set; }

    /// <summary>
    /// Gets or sets the maximum time in seconds that a preflight request may be cached by the browser.
    /// </summary>
    [Comment("The maximum time (in seconds) that the results of a preflight request can be cached by the browser. For example, 3600 means the preflight response can be cached for 1 hour. If no value is provided, it can be null to indicate no caching.")]
    public int? MaxAgeInSeconds { get; set; }

    /// <summary>
    /// Gets or sets an optional description for the CORS policy.
    /// </summary>
    [Comment("A brief description of the CORS policy, explaining its purpose (optional)")]
    public string? CorsPolicyDescription { get; set; }
}
