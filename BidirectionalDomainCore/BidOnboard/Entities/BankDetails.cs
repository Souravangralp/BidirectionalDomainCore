namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class BankDetail : BaseAuditableEntity
{
    public int? BankDetail_UserID { get; set; }

    public int? BankDetail_BusinessDetailID { get; set; }

    public int? BankDetail_BusinessUnitID { get; set; }

    public int? BankDetail_OrganizationID { get; set; }

    public int? AccountNameType_CoreDB_GeneralLookUpID { get; set; }

    [EncryptColumn]
    public string? BankName { get; set; }

    [EncryptColumn]
    public string? BSB { get; set; } // Bank State Branch (BSB) number

    [EncryptColumn]
    public string? AccountNumber { get; set; }

    public string? MYOBAdvancedVendorID { get; set; }

    public bool IsCommissionAccount { get; set; }

    public User? BankDetail_User { get; set; }

    public BusinessDetail? BankDetail_BusinessDetail { get; set; }

    public BusinessUnit? BankDetail_BusinessUnit { get; set; }

    public Organization? BankDetail_Organization { get; set; }

    public ICollection<EmailDetail> Emails { get; set; } = [];

    public ICollection<DocumentDetail> Documents { get; set; } = [];
}
