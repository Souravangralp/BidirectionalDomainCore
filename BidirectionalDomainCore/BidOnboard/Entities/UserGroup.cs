namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class UserGroup : BaseAuditableEntity
{
    public string? GroupID { get; set; }

    public string? GroupName { get; set; }

    public int? UserGroupType_CoreDB_GeneralLookUpID { get; set; }

    public int? GroupType_CoreDB_GeneralLookUpID { get; set; }

    public int? ParentGroupID { get; set; }

    public UserGroup? ParentGroup { get; set; }

    public ICollection<UserGroup> SubGroups { get; set; } = [];
}
