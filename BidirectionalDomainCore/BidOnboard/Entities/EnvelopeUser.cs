namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class EnvelopeUser : BaseAuditableEntity
{
    public int? EnvelopeUser_UserID { get; set; }

    public int? EnvelopeUser_AcceptedAgreementDetailID { get; set; }

    public int? EnvelopeUser_ExternalUserID { get; set; }

    public string? Status { get; set; }

    public User? EnvelopeUser_User { get; set; }

    public DateTime? SignatureDate { get; set; }

    public AcceptedAgreementDetail? EnvelopeUser_AcceptedAgreementDetail { get; set; }

    public ExternalUser? EnvelopeUser_ExternalUser { get; set; }
}
