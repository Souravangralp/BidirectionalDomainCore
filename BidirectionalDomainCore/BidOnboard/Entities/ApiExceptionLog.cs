namespace Bidirectional.DomainCore.BidOnboard.Entities;

/// <summary>
/// Represents a log entry for API exceptions, including request, response, and notification details.
/// </summary>
public class ApiExceptionLog : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the name of the API where the exception occurred.
    /// </summary>
    public string? ApiName { get; set; }

    /// <summary>
    /// Gets or sets the HTTP status code returned by the API.
    /// </summary>
    public string? HTTPStatusCode { get; set; }

    /// <summary>
    /// Gets or sets the HTTP reason phrase associated with the status code.
    /// </summary>
    public string? HTTPReasonPhrase { get; set; }

    /// <summary>
    /// Gets or sets the message of the API request that caused the exception.
    /// </summary>
    public string? APIRequestMessage { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a notification email was sent for the exception.
    /// </summary>
    public bool ISNotificationEmailSent { get; set; }
}
