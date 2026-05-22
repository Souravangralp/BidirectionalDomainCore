namespace Bidirectional.DomainCore.BidOnboard.Persistence.Abstractions
{
    /// <summary>
    /// Represents a group of general lookup key/value items by type.
    /// </summary>
    public class GeneralLookUpGroupedDto
    {
        /// <summary>
        /// Gets or sets the lookup type for this group.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the collection of lookup key/value items.
        /// </summary>
        public List<GeneralLookUpKeyValueDto> Items { get; set; } = [];
    }

    /// <summary>
    /// Represents a key/value pair for a general lookup item.
    /// </summary>
    public class GeneralLookUpKeyValueDto
    {
        /// <summary>
        /// Gets or sets the key identifier for the lookup item.
        /// </summary>
        public int Key { get; set; }

        /// <summary>
        /// Gets the ID for the lookup item (alias for <see cref="Key"/>).
        /// </summary>
        public int ID
        {
            get { return Key; }
        }

        /// <summary>
        /// Gets or sets the display value for the lookup item.
        /// </summary>
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the optional sort order.
        /// </summary>
        public int? Order { get; set; }
    }

}
