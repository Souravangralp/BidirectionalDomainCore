using Bidirectional.DomainCore.BidOnboard.ValueObjects;

namespace Bidirectional.DomainCore.ProductMatrix.Entities
{
    /// <summary>
    /// Represents a to-do list, containing a collection of to-do items, title, and display colour.
    /// </summary>
    public class TodoList : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the title of the to-do list.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the colour associated with the to-do list.
        /// </summary>
        public Colour Colour { get; set; } = Colour.White;

        /// <summary>
        /// Gets the collection of to-do items within the list.
        /// </summary>
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
