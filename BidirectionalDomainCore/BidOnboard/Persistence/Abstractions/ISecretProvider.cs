namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions;

public interface ISecretProvider
{
    Task<string> GetAsync(string name);
}
