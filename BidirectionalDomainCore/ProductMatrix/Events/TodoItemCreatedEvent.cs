using Bidirectional.DomainCore.ProductMatrix.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bidirectional.DomainCore.ProductMatrix.Event
{
    /// <summary>
    /// Event that is triggered when a new <see cref="TodoItem"/> is created.
    /// </summary>
    public class TodoItemCreatedEvent : BaseEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoItemCreatedEvent"/> class.
        /// </summary>
        /// <param name="item">The newly created todo item.</param>
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        /// <summary>
        /// Gets the todo item associated with the event.
        /// </summary>
        public TodoItem Item { get; }
    }

}
