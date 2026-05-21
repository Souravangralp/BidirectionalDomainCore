namespace Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;

public class AssignedQuestion : BaseAuditableEntity
{
    public string QuestionText { get; set; } = string.Empty;

    public int? ResponsibilityQuestionType_GeneralLookUpID { get; set; }

    public QuestionType Type { get; set; }

    public bool ISMandatory { get; set; } = true;

    public int Order { get; set; }

    public int? ParentQuestionID { get; set; }

    public AssignedQuestion? ParentQuestion { get; set; }

    public ICollection<ResponsibilityQuestion> ChildQuestions { get; set; } = new List<ResponsibilityQuestion>();

    public string? ConditionValue { get; set; }

    public decimal? MinValue { get; set; }

    public decimal? MaxValue { get; set; }

    public double? ScoreQuestion { get; set; }

    public ICollection<ResponsibilityQuestionUserMapper> UserAnswers { get; set; } = new List<ResponsibilityQuestionUserMapper>();

    public ICollection<ResponsibilityQuestionAssignedUserGroupMapper> ResponsibilityQuestionAssignedUserGroupMapper { get; set; } = new List<ResponsibilityQuestionAssignedUserGroupMapper>();
}
