namespace Bidirectional.DomainCore.BidOnboard.Enums
{
    /// <summary>
    /// Represents the possible refinance statuses for a property.
    /// </summary>
    public enum PropertyRefinanceStatus
    {
        /// <summary>
        /// Indicates that there is no refinance status assigned.
        /// </summary>
        None = 0,

        /// <summary>
        /// Indicates that the property is scheduled to be refinanced.
        /// </summary>
        ToBeRefinanced = 1,

        /// <summary>
        /// Indicates that the property has been refinanced.
        /// </summary>
        Refinanced = 2,
    }
}
