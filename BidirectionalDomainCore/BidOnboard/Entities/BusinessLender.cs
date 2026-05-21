namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessLender : BaseAuditableEntity
{
    public int? BusinessLender_BusinessDetailID { get; set; }

    public string? LenderName { get; set; } // we may choses Options: https://www.canstar.com.au/providers/home-loans/

    public string? LenderID { get; set; }

    public BusinessDetail? BusinessLender_BusinessDetail { get; set; }
}
