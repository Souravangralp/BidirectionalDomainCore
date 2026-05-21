namespace Bidirectional.DomainCore.BidOnboard.Entities.Liabilities;

public class CreditCardLiability : BaseAuditableEntity
{
    public int Liability_UserID { get; set; }

    public string? ProviderName { get; set; }

    public string? CardNumber { get; set; }

    public double CreditLimit { get; set; }

    public double MinimumMonthlyPayment { get; set; }

    public float InterestRate { get; set; }

    public bool ISBalanceTransfer { get; set; }

    public double CurrentOutstandingBalance { get; set; }

    public User? Liability_User { get; set; }
}
