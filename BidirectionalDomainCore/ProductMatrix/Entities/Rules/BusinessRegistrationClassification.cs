namespace Bidirectional.DomainCore.ProductMatrix.Entities.Rules;

/// <summary>
/// Represents the classification details for a business registration, including registration type, document type, and related lookup IDs.
/// </summary>
public class BusinessRegistrationClassification : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the general lookup ID for the loan type from the core database.
    /// </summary>
    public int? LoanType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the business registration type from the core database.
    /// </summary>
    public int? BusinessRegistrationType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the general lookup ID for the document type from the core database.
    /// </summary>
    public int? DocType_CoreDB_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the business is registered.
    /// </summary>
    public bool ISRegistered { get; set; }

    /// <summary>
    /// Gets or sets the value indicating heedful points associated with the registration.
    /// </summary>
    public int? HeedfulPoints { get; set; }
}
