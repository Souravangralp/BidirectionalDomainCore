namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents public record information associated with a loan application, including identifiers,
/// types, amounts, and related customer introduction details.
/// </summary>
public class PublicRecordInformation : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the foreign key linking to the associated IntroductionToTheCustomer entity.
    /// </summary>
    public int PublicRecordInformation_IntroductionToTheCustomerID { get; set; }

    /// <summary>
    /// Gets or sets the lookup ID for the type of public record information, referencing the GeneralLookUp table.
    /// </summary>
    [Comment("all fields seeded under Type 'PublicRecordInformation' in GeneralLookUp Table")]
    public int? PublicRecordInformationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the number relevant to the public record entry.
    /// </summary>
    public int? Number { get; set; }

    /// <summary>
    /// Gets or sets the amount associated with the public record entry.
    /// </summary>
    public double? Amount { get; set; }

    /// <summary>
    /// Gets or sets the related IntroductionToTheCustomer entity for this public record entry.
    /// </summary>
    public IntroductionToTheCustomer? PublicRecordInformation_IntroductionToTheCustomer { get; set; }
}
