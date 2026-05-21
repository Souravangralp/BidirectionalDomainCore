namespace Bidirectional.DomainCore.BidOnboard.Entities;

public class DocumentDetail : BaseAuditableEntity
{
    public int? DocumentType_CoreDB_GeneralLookUpID { get; set; }

    public int? DocumentDetail_UserID { get; set; }

    public int? DocumentDetail_BusinessUnitID { get; set; }

    public int? DocumentDetail_OrganizationID { get; set; }

    public int? DocumentDetail_BankDetailID { get; set; }

    public string? Url { get; set; } // Document URL where the document may be stored

    public string? Comment { get; set; } // Additional comments about the document

    public string? DocumentName { get; set; } // Descriptive name for the document

    public string? DocumentType { get; set; } // Document type (e.g. 'PDF', 'Image')

    public string? FileFormat { get; set; } // Document file format (e.g. 'jpeg', 'png')

    public long? FileSize { get; set; } // Size of the document in bytes

    public bool HasExpirationDate { get; set; }

    public DateOnly? ExpirationDate { get; set; } // Expiration date (if applicable)

    public bool ISVerifiedByOCR { get; set; } // Whether the document has been verified by OCR

    public DateTime? VerifiedByOCRAt { get; set; } // Date and time when the document was verified by OCR

    public string? VerifiedByOCRReference { get; set; } // Reference or ID from the OCR verification

    public bool ISVerifiedByUser { get; set; } // Whether the document has been verified manually

    public DateTime? VerifiedByUserAt { get; set; } // Date and time when the document was verified manually

    public string? VerifiedByUserID { get; set; } // ID of the user who verified the document

    public bool ISVerifiedByThirdParty { get; set; } // Whether the document has been verified by a third party

    public DateTime? VerifiedByThirdPartyAt { get; set; } // Date and time when the document was verified by a third party

    public string? VerifiedByThirdPartyReference { get; set; } // Reference or ID from the third party verification

    public string? DocumentLocation { get; set; } // Location or path of the document

    public string? Status { get; set; } // Current status (e.g., 'Pending', 'Approved')

    public string? OcrDetectedText { get; set; } // Text detected from OCR

    public string? RelatedDocuments { get; set; } // Related documents, possibly in JSON format

    public bool ISBlobUrlUpdateNeeded { get; set; } // Whether the document URL needs to be updated

    public User? DocumentDetail_User { get; set; }

    public BusinessUnit? DocumentDetail_BusinessUnit { get; set; }

    public Organization? DocumentDetail_Organization { get; set; }

    public BankDetail? DocumentDetail_BankDetail { get; set; }
}
