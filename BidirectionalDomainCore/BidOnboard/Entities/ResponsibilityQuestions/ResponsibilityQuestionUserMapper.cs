namespace Bidirectional.DomainCore.BidOnboard.Entities.ResponsibilityQuestions;

public class ResponsibilityQuestionUserMapper : BaseAuditableEntity
{
    public int? ResponsibilityQuestionUserMapper_UserID { get; set; }

    public int? ResponsibilityQuestionUserMapper_AssignedQuestionID { get; set; }

    public ResponsibilityQuestionStatus QuestionStatus { get; set; }

    public string? AnswerText { get; set; }

    public decimal? AnswerNumber { get; set; }

    public YesNoOption? AnswerOption { get; set; }

    public User? ResponsibilityQuestionUserMapper_User { get; set; }

    public AssignedQuestion? ResponsibilityQuestionUserMapper_AssignedQuestion { get; set; }
}
