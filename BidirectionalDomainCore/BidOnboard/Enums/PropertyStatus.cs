namespace Bidirectional.DomainCore.BidOnboard.Enums
{
    /// <summary>
    /// Specifies the security status of an asset, indicating whether it is encumbered, used as security, or both.
    /// </summary>
    public enum AssetSecurityStatus
    {
        /// <summary>
        /// The asset has no security assignment or encumbrance.
        /// </summary>
        None = 0,
        /// <summary>
        /// The asset is encumbered but not used as security.
        /// </summary>
        Encumbered = 1,
        /// <summary>
        /// The asset is used as security but is not otherwise encumbered.
        /// </summary>
        UsedAsSecurity = 2,
        /// <summary>
        /// The asset is both encumbered and used as security.
        /// </summary>
        EncumberedAsSecurity = Encumbered | UsedAsSecurity
    }

    /// <summary>
    /// Defines the origin or classification of an asset, such as whether it is unencumbered, encumbered, or held as security.
    /// </summary>
    public enum AssetOrigin
    {
        /// <summary>
        /// The asset is unencumbered and free of claims.
        /// </summary>
        UnEncumbered = 0,
        /// <summary>
        /// The asset is encumbered by liabilities or claims.
        /// </summary>
        Encumbered = 1,
        /// <summary>
        /// The asset is held specifically as security.
        /// </summary>
        Security = 2,
    }
}
