using Bidirectional.DomainCore.ProductMatrix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.ProductMatrix.Event
{
    /// <summary>
    /// Represents an event that is triggered when a TodoItem is marked as completed.
    /// </summary>
    public class TodoItemCompletedEvent : BaseEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoItemCompletedEvent"/> class.
        /// </summary>
        /// <param name="item">The TodoItem that has been completed.</param>
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        /// <summary>
        /// Gets the TodoItem associated with the completed event.
        /// </summary>
        public TodoItem Item { get; }
    }
}
