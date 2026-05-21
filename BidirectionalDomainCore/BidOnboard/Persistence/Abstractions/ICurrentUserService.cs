namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

public interface ICurrentUserService
{
    string? UserID { get; }

    int? RawUserID { get; }

    string? UserName { get; }

    string? AzureAccountID { get; }

    string? OrganizationID { get; }

    int? RawOrganizationID { get; }

    string? BusinessUnitID { get; }

    int? RawBusinessUnitID { get; }

    string? GroupID { get; }

    string? AggregatorID { get; }

    int? RawAggregatorID { get; }
}
