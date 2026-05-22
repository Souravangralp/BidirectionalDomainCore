namespace Bidirectional.DomainCore.ProductMatrix.Exceptions
{
    /// <summary>
    /// Represents errors that occur when executing SQL-related operations in the application.
    /// </summary>
    public class SQLException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SQLException"/> class with a specified error message.
        /// </summary>
        /// <param name="value">The message that describes the error.</param>
        public SQLException(string value) : base(value) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public SQLException(string message, Exception innerException) : base(message, innerException) { }
    }

}
