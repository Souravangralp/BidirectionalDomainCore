namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a customer loan declaration entity containing information about a customer's loan declaration type and description.
/// </summary>
public class CustomerLoanDeclaration : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier for the related customer declaration.
    /// </summary>
    public int? CustomerLoanDeclaration_CustomerDeclarationID { get; set; }

    /// <summary>
    /// Gets or sets the identifier for the loan declaration type from the core database general lookup.
    /// </summary>
    public int? CustomerLoanDeclarationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the description of the loan declaration.
    /// </summary>
    public string? LoanDeclarationDescription { get; set; }

    /// <summary>
    /// Gets or sets the related customer declaration entity.
    /// </summary>
    public CustomerDeclaration? CustomerLoanDeclaration_CustomerDeclaration { get; set; }
}
