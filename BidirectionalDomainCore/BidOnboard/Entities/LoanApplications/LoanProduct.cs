namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a loan product associated with a loan detail, including category, code, member, and organisation information.
/// </summary>
public class LoanProduct : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the related loan detail.
    /// </summary>
    public int? LoanProduct_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets the category of the loan product.
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Gets or sets the code of the loan product.
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Gets or sets the member identifier associated with the loan product.
    /// </summary>
    public string? MemberID { get; set; }

    /// <summary>
    /// Gets or sets the name of the loan product.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Gets or sets the option code related to the loan product.
    /// </summary>
    public string? OptionCode { get; set; }

    /// <summary>
    /// Gets or sets the organisation associated with the loan product.
    /// </summary>
    public string? Organisation { get; set; }

    /// <summary>
    /// Gets or sets the associated loan detail entity for this loan product.
    /// </summary>
    public LoanDetail? LoanProduct_LoanDetail { get; set; }
}
