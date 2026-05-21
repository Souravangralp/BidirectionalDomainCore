namespace Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;

public class ResponsibilityQuestionUserGroupMapper : BaseAuditableEntity
{
    public int? ResponsibilityQuestionUserGroupMapper_ResponsibilityQuestionID { get; set; }

    public int? ResponsibilityQuestionUserGroupMapper_UserGroupID { get; set; }

    public ResponsibilityQuestion? ResponsibilityQuestionUserGroupMapper_ResponsibilityQuestion { get; set; }

    public UserGroup? ResponsibilityQuestionUserGroupMapper_UserGroup { get; set; }
}
