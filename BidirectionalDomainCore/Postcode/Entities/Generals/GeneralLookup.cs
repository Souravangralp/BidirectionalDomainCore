namespace Bidirectional.DomainCore.Postcode.Entities.Generals;

/// <summary>
/// Represents a general lookup entity with a type, value, and default indicator.
/// </summary>
public class GeneralLookup : BaseAuditableEntity
{
    [TextClass(TextFieldClass.Ignored)]
    public required string Type { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public required string Value { get; set; }

    public bool ISDefault { get; set; }

    public int? Order { get; set; }

    public List<LookupValueRelation> Parents { get; set; } = [];

    public List<LookupValueRelation> Children { get; set; } = [];
}
