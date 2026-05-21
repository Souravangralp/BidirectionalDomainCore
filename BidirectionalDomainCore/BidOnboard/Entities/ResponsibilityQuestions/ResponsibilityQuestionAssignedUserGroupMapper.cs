namespace Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;

public class ResponsibilityQuestionAssignedUserGroupMapper : BaseAuditableEntity
{
    public int? ResponsibilityQuestionAssignedUserGroupMapper_ResponsibilityQuestionID { get; set; }

    public int? ResponsibilityQuestionAssignedUserGroupMapper_AssignedQuestionID { get; set; }

    public int? ResponsibilityQuestionAssignedUserGroupMapper_UserGroupID { get; set; }

    public AssignedQuestion? ResponsibilityQuestionAssignedUserGroupMapper_AssignedQuestion { get; set; }

    public ResponsibilityQuestion? ResponsibilityQuestionAssignedUserGroupMapper_ResponsibilityQuestion { get; set; }

    public UserGroup? ResponsibilityQuestionAssignedUserGroupMapper_UserGroup { get; set; }
}
