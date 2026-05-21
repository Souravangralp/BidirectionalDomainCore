namespace Bidirectional.DomainCore.BidOnboard.Exceptions;

/// <summary>
/// Exception thrown when a specified colour code is not supported.
/// </summary>
public class UnsupportedColourException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnsupportedColourException"/> class with a specified unsupported colour code.
    /// </summary>
    /// <param name="code">The colour code that is unsupported.</param>
    public UnsupportedColourException(string code)
        : base($"Colour \"{code}\" is unsupported.")
    {
    }
}
