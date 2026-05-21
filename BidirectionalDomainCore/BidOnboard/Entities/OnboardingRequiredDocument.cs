namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class OnboardingRequiredDocument : BaseAuditableEntity
{
    public int? OnboardingRequiredDocument_EntityUserGroupMappingID { get; set; }

    public int? DocumentType_CoreDB_GeneralLookUpID { get; set; }

    public bool ISMandatory { get; set; }

    public EntityUserGroupMapping? OnboardingRequiredDocument_EntityUserGroupMapping { get; set; }
}
