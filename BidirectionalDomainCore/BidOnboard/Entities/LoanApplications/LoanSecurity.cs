namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents a loan security, including details about the associated loan split, real estate asset, security classification, security value, and lien position.
/// </summary>
public class LoanSecurity : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the identifier of the associated loan split linked to the loan security.
    /// </summary>
    public int? LoanSecurity_LoanSplitID { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the associated real estate asset used as security for the loan.
    /// </summary>
    public int? LoanSecurity_RealEstateAssetID { get; set; }

    /// <summary>
    /// Gets or sets the classification type identifier for the loan security.
    /// </summary>
    public int? SecurityClassificationType_GeneralLookUpID { get; set; }

    /// <summary>
    /// Gets or sets the current value of the security.
    /// </summary>
    [Comment("Current security value")]
    public double? CurrentSecurityValue { get; set; }

    /// <summary>
    /// Gets or sets the security Loan to Value Ratio (LVR).
    /// </summary>
    public double? SecurityLVR { get; set; }

    /// <summary>
    /// Gets or sets the lien position type identifier for the loan security.
    /// </summary>
    public int? LienPositionType_GeneralLookUPID { get; set; }

    /// <summary>
    /// Gets or sets the associated loan split entity.
    /// </summary>
    public LoanSplit? LoanSecurity_LoanSplit { get; set; }

    /// <summary>
    /// Gets or sets the associated real estate asset entity used as security.
    /// </summary>
    public RealEstateAsset? LoanSecurity_RealEstateAsset { get; set; }
}
