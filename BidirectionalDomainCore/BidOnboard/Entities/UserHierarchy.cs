namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class UserHierarchy : BaseAuditableEntity
{
    public int? UserHierarchy_ParentUserID { get; set; } // Parent User ID

    public int? UserHierarchy_ChildUserID { get; set; } // Child User ID

    public User? UserHierarchy_ParentUser { get; set; } // Navigation property for Parent User

    public User? UserHierarchy_ChildUser { get; set; } // Navigation property for Child User
}
