namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BusinessPanelFinancialInstitution : BaseAuditableEntity
{
    public int? BusinessPanelInstitution_OrganizationID { get; set; }

    public string InstitutionName { get; set; } = null!;

    public double? AnnualVolume { get; set; }

    public int? YearEstablished { get; set; }

    public Organization? BusinessPanelInstitution_Organization { get; set; }
}
