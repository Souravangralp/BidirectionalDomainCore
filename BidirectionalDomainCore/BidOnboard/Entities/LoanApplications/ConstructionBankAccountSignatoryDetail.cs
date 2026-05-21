namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the details of an authorized signatory for a construction bank account.
/// </summary>
public class ConstructionBankAccountSignatoryDetail : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the ID of the associated construction project.
    /// </summary>
    public int? ConstructionBankAccountSignatoryDetail_ConstructionID { get; set; }

    /// <summary>
    /// Gets or sets the name of the bank account signatory.
    /// </summary>
    public string? BankAccountSignatoryName { get; set; }

    /// <summary>
    /// Gets or sets the mobile phone number of the bank account signatory.
    /// </summary>
    public string? BankAccountSignatoryMobile { get; set; }

    /// <summary>
    /// Gets or sets the email address of the bank account signatory.
    /// </summary>
    public string? BankAccountSignatoryEmail { get; set; }

    /// <summary>
    /// Gets or sets the related construction entity.
    /// </summary>
    public Construction? ConstructionBankAccountSignatoryDetail_Construction { get; set; }
}
