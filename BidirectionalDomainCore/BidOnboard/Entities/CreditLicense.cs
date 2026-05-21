using System.ComponentModel.DataAnnotations;

namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class CreditLicense : BaseAuditableEntity
{
    public string? RegisterName { get; set; }

    public string? CreditLicenseNumber { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? CreditLicenseName { get; set; }

    public DateTime? CreditLicenseStartDate { get; set; }

    public DateTime? CreditLicenseEndDate { get; set; }

    public string? CreditLicenseStatus { get; set; }

    public string? CreditLicenseAbnAcn { get; set; }

    public string? CreditLicenseAfslNumber { get; set; }

    [MaxLength(2000)]
    [TextClass(TextFieldClass.Ignored)]
    public string? CreditLicenseStatusHistory { get; set; }

    public string? CreditLicenseLocality { get; set; }

    public string? CreditLicenseState { get; set; }

    public string? CreditLicensePostcode { get; set; }

    public double? CreditLicenseLatitude { get; set; }

    public double? CreditLicenseLongitude { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? CreditLicenseEdrs { get; set; }

    [MaxLength(255)]
    [TextClass(TextFieldClass.Ignored)]
    public string? CreditLicenseBn { get; set; }

    public string? CreditLicenseAuthorisations { get; set; }
}
