namespace Bidirectional.DomainCore.BidOnboard.Constants;

public record DocumentSignApi
{
    // Use https://www.docusign.net for production

    public const string BasePath = "https://demo.docusign.net/restapi/v2.1";

    public static readonly string CreateEnvelopeApi = $"{BasePath}/accounts/{{0}}/envelopes";

    public static readonly string GetEnvelopeApi = $"{BasePath}/accounts/{{0}}/envelopes/{{1}}/views/recipient";
}

public record DocumentSignStatusConstant
{
    public const string RecipientCompleted = "recipient-completed";

    public const string RecipientDeclined = "recipient-declined";

    public const string EnvelopeCompleted = "envelope-completed";

    public const string EnvelopeSent = "envelope-sent";

    public const string EnvelopeDeclined = "envelope-declined";

    public const string PolicyAcceptancePending = "policy-acceptance-pending";

    public const string PolicyAccepted = "policy-accepted";

    public const string PolicyRejected = "policy-rejected";

    private static readonly HashSet<string> ValidStatuses = new(StringComparer.OrdinalIgnoreCase)
    {
        RecipientCompleted,
        RecipientDeclined,
        EnvelopeCompleted,
        EnvelopeDeclined,
        EnvelopeSent,
    };

    public static bool CheckPropertyExists(string statusName)
    {
        return ValidStatuses.Contains(statusName);
    }
}
