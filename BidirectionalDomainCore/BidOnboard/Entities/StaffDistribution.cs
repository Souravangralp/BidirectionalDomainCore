namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class StaffDistribution : BaseAuditableEntity
{
    public int? StaffDistribution_OrganizationID { get; set; }

    public int? StaffDistributionType_CoreDB_GeneralLookUpID { get; set; }

    public int? NumberOfEmployees { get; set; }

    public Organization? StaffDistribution_Organization { get; set; }
}
