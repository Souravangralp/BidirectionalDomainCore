using Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;
using Bidirectional.DomainCore.BidOnboard.Entities;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class AcceptedPrivacyPolicy : BaseAuditableEntity
{
    public int? AcceptedPrivacyPolicy_UserID { get; set; }

    public int? AcceptedPrivacyPolicy_LoanApplicationID { get; set; }

    [TextClass(TextFieldClass.Ignored)]
    public string? PolicyUrl { get; set; }

    public bool ISAccepted { get; set; } = false;

    public DateTime? AcceptedDateUtc { get; set; } = DateTime.UtcNow;

    public string? IPAddress { get; set; }

    public User? AcceptedPrivacyPolicy_User { get; set; }

    public IList<Applicant> AcceptedPrivacyPolicy_Applicant { get; set; } = [];

    public LoanApplication? AcceptedPrivacyPolicy_LoanApplication { get; set; }
}
