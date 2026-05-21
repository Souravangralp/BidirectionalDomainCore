namespace Bidirectional.DomainCore.BidOnboard.Exceptions;

/// <summary>
/// Represents errors that occur when an operation is invoked at an invalid time or under invalid conditions.
/// </summary>
public class InvalidOperationException : Exception
{
    /// <summary>
    /// Gets the name of the operation that caused the exception, if specified.
    /// </summary>
    public string? OperationName { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOperationException"/> class.
    /// </summary>
    public InvalidOperationException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOperationException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public InvalidOperationException(string message)
        : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOperationException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="inner">The exception that is the cause of the current exception.</param>
    public InvalidOperationException(string message, Exception inner)
        : base(message, inner) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOperationException"/> class with a specified error message and the name of the operation.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="operationName">The name of the operation that caused the exception.</param>
    public InvalidOperationException(string message, string operationName)
        : this(message)
    {
        OperationName = operationName;
    }
}
