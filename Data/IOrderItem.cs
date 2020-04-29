using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing order item
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of thies order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The special instructions for this order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
