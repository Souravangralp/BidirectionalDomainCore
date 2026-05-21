namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class Language : BaseAuditableEntity
{
    public int? Language_UserID { get; set; }

    public string? Name { get; set; }

    public int? SpokenProficiencyLevel_CoreDB_GeneralLookUpID { get; set; } // Fluent, Intermediate, Basic

    public int? WritingProficiencyLevel_CoreDB_GeneralLookUpID { get; set; } // Fluent, Intermediate, Basic

    public bool ISNativeLanguage { get; set; }

    public User? Language_User { get; set; }
}
