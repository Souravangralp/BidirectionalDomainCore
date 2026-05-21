namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class FormEntry : BaseAuditableEntity
{
    public int? FormEntry_OrganizationID { get; set; }

    public int? FormEntry_BusinessUnitID { get; set; }

    public int? FormEntry_UserID { get; set; }

    public int? FormEntryType_CoreDB_GeneralLookUpID { get; set; }

    public bool? BooleanValue { get; set; }

    public string? TextValue { get; set; }

    public double? NumericValue { get; set; }

    public DateTime? DateValue { get; set; }

    public Organization? FormEntry_Organization { get; set; }

    public BusinessUnit? FormEntry_BusinessUnit { get; set; }

    public User? FormEntry_User { get; set; }
}
