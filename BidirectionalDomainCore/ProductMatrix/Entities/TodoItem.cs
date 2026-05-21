using Bidirectional.DomainCore.ProductMatrix.Event;

namespace Bidirectional.DomainCore.ProductMatrix.Entities
{
    /// <summary>
    /// Represents a to-do item entity with priority, completion status, reminder, and associated list.
    /// </summary>
    public class TodoItem : BaseAuditableEntity
    {
        /// <summary>
        /// Gets or sets the identifier of the associated to-do list.
        /// </summary>
        public int ListId { get; set; }

        /// <summary>
        /// Gets or sets the title of the to-do item.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets a note or additional details for the to-do item.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets or sets the priority level of the to-do item.
        /// </summary>
        public PriorityLevel Priority { get; set; }

        /// <summary>
        /// Gets or sets the optional date and time to be reminded about the to-do item.
        /// </summary>
        public DateTime? Reminder { get; set; }

        private bool _done;

        /// <summary>
        /// Gets or sets a value indicating whether the to-do item is completed.
        /// </summary>
        public bool Done
        {
            get => _done;
            set
            {
                if (value && !_done)
                {
                    AddDomainEvent(new TodoItemCompletedEvent(this));
                }

                _done = value;
            }
        }

        /// <summary>
        /// Gets or sets the to-do list that this item belongs to.
        /// </summary>
        public TodoList List { get; set; } = null!;
    }

}
