using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BSBDirectory : BaseAuditableEntity
{
    public string? BSB { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? Mnemonic { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? Name { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? Address { get; set; }

    public string? Location { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? PlaceType { get; set; }
}
