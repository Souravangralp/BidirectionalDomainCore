using Bidirectional.DomainCore.Postcode.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class State : BaseAuditableEntity
{
    public int? State_CountryID { get; set; } // Foreign key to the Country table

    [TextClass(TextFieldClass.Ignored)]
    public string? Name { get; set; } // Name of the state or province

    [TextClass(TextFieldClass.Ignored)]
    public string? State_Code { get; set; } // State or province code (e.g., 'CA' for California, 'NSW' for New South Wales)

    public string? Region { get; set; } // Region or part of the country (e.g., 'West Coast', 'Midwest')

    public bool ISDefault { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    [Comment("Vic")]
    public required string AbbreviatedName { get; set; }

    public bool ISTerritory { get; set; }

    public Country? State_Country { get; set; } // Navigation property to the Country table (optional, if you want to store country information here too)

    public List<Suburb> Suburbs { get; set; } = [];
}
