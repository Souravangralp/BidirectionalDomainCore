namespace Bidirectional.DomainCore.BidOnboard.Entities.LoanApplications;

/// <summary>
/// Represents the set of additional features selected for a specific loan application.
/// </summary>
public class SelectedFeature : BaseAuditableEntity
{
    /// <summary>
    /// Gets or sets the loan detail identifier associated with the selected features.
    /// </summary>
    public int? SelectedFeature_LoanDetailID { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a cheque book is selected.
    /// </summary>
    public bool ISChequeBook { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a debit card is selected.
    /// </summary>
    public bool ISDebitCard { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a deposit book is selected.
    /// </summary>
    public bool ISDepositBook { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether holiday leave is selected.
    /// </summary>
    public bool ISHolidayLeave { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether an offset feature is selected.
    /// </summary>
    public bool ISOffset { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether parental leave is selected.
    /// </summary>
    public bool ISParentalLeave { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a partial offset is selected.
    /// </summary>
    public bool ISPartialOffset { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether portability is selected.
    /// </summary>
    public bool ISPortability { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether progressive draw is selected.
    /// </summary>
    public bool ISProgressiveDraw { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a rate lock is selected.
    /// </summary>
    public bool ISRateLock { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a redraw option is selected.
    /// </summary>
    public bool ISRedraw { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether split loan is selected.
    /// </summary>
    public bool ISSplitLoan { get; set; }

    /// <summary>
    /// Gets or sets the navigation property to the loan detail associated with the selected features.
    /// </summary>
    public LoanDetail? SelectedFeature_LoanDetail { get; set; }
}
