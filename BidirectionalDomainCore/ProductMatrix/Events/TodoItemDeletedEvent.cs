using Bidirectional.DomainCore.ProductMatrix.Entities;

namespace Bidirectional.DomainCore.ProductMatrix.Event
{
    /// <summary>
    /// Represents the event that occurs when a <see cref="TodoItem"/> is deleted.
    /// </summary>
    public class TodoItemDeletedEvent : BaseEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoItemDeletedEvent"/> class.
        /// </summary>
        /// <param name="item">The deleted to-do item associated with the event.</param>
        public TodoItemDeletedEvent(TodoItem item)
        {
            Item = item;
        }

        /// <summary>
        /// Gets the to-do item that was deleted.
        /// </summary>
        public TodoItem Item { get; }
    }

}
