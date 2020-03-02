﻿using System;
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
        private uint lastOrderNumber;

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
        public double Subtotal { get; }
        
        /// <summary>
        /// the current order number
        /// </summary>
        public uint OrderNumber { get; }

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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        /// <summary>
        /// the method to remove item from the order
        /// </summary>
        /// <param name="item">the item removed from</param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

    }
}