using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class representing a order
    /// </summary>
    public class Order: INotifyPropertyChanged
    {
        /// <summary>
        /// the last order number
        /// </summary>
        private static uint lastOrderNumber = 0;

        /// <summary>
        /// the list of items in the order
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();
        
        /// <summary>
        /// the Inumerable items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// the subtotal of the order
        /// </summary>
        public double Subtotal { get; private set; }
        
        /// <summary>
        /// the current order number
        /// </summary>
        public uint OrderNumber { get { return lastOrderNumber++;  } }

        /// <summary>
        /// the property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the method to add item in the order
        /// </summary>
        /// <param name="item">the item added in</param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        /// <summary>
        /// the method to remove item from the order
        /// </summary>
        /// <param name="item">the item removed from</param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

    }
}
