namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class DocuSignRequest : BaseAuditableEntity
{
    public string? RequestData { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? RequestDateTime { get; set; } = DateTime.UtcNow;
}
