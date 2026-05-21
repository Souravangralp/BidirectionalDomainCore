namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Country : BaseAuditableEntity
{
    public string? Name { get; set; } // Country name

    public string? Code { get; set; } // Country code (ISO code, for example, 'US' for United States)

    public string? Region { get; set; } // Continent or region (optional)

    public string? Currency { get; set; } // Country's currency (optional)

    public string? Language { get; set; } // Primary language spoken (optional)

    [TextClass(TextFieldClass.Ignored)]
    public string? ISO3Code { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public string? ISO2Code { get; set; }

    public bool ISDefault { get; set; }

    public ICollection<State> States { get; set; } = [];
}
