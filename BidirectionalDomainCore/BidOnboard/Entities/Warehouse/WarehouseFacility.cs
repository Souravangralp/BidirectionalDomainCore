namespace Bidirectional.DomainCore.BidOnboard.Entities.Warehouse;

public class WarehouseFacility : BaseAuditableEntity
{
    public int? WarehouseFacility_OrganizationID { get; set; }

    public string? WarehouseLineName { get; set; }

    public double? MaximumCreditLimit { get; set; }

    public string? Currency { get; set; }

    public double? AdvanceRate { get; set; }

    public double? Margin { get; set; }

    public double? MaximumLoanAmount { get; set; }

    public double? MaximumLVR { get; set; }

    public int? AllowedPropertyUsage { get; set; }

    public ICollection<WarehouseFundingType> FundingTypes { get; set; } = [];

    public ICollection<WarehouseLoanType> AllowedLoanTypes { get; set; } = new List<WarehouseLoanType>();

    public ICollection<WarehouseInterestRate> InterestRates { get; set; } = new List<WarehouseInterestRate>();

    public ICollection<WarehousePropertyType> PropertyTypes { get; set; } = new List<WarehousePropertyType>();

    public ICollection<WarehouseGeographicCoverage> GeographicCoverages { get; set; } = new List<WarehouseGeographicCoverage>();

    public Organization? WarehouseFacility_Organization { get; set; }
}
