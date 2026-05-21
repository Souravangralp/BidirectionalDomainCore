using Bidirectional.DomainCore.Postcode.Entities.Generals;
using Bidirectional.DomainCore.Postcode.Entities.Mappers;
using Bidirectional.DomainCore.Postcode.Entities;
using Microsoft.EntityFrameworkCore;

namespace Bidirectional.DomainCore.Postcode.Exceptions;

/// <summary>
/// Represents an exception that is thrown when an unsupported colour code is encountered.
/// </summary>
public class UnsupportedColourException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnsupportedColourException"/> class with the specified colour code.
    /// </summary>
    /// <param name="code">The colour code that is not supported.</param>
    public UnsupportedColourException(string code)
        : base($"Colour \"{code}\" is unsupported.")
    {
    }
}
