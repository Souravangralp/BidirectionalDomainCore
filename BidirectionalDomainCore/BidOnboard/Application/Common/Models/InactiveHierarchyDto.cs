namespace Bidirectional.DomainCore.BidOnboard.Application.Common.Models;

public class InactiveHierarchyDto
{
    public string? EntityType { get; set; }

    public string? Name { get; set; }

    public bool IsActive { get; set; }

    public string? ParentOrCurrent { get; set; }
}
