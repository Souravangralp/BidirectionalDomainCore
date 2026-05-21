using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class EmailTemplate : BaseAuditableEntity
{
    public int? TemplateType_CoreDB_GeneralLookUpID { get; set; }

    public int? ContactType_CoreDB_GeneralLookUpID { get; set; }

    [MaxLength(500)]
    [TextClass(TextFieldClass.Ignored)]
    public string? TemplateName { get; set; }

    public string? TemplateBody { get; set; } // this may be contain html content

    public bool ISTwilioTemplate { get; set; }

    public string? TwilioTemplateID { get; set; } // this will hold email template id which is creating at Twilio

    public DateTime CreatedDate { get; set; }
}
