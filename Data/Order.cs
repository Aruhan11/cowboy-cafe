/*
 * Author: Aruhan
 * Class: Order.cs
 * Purpose: the class representing a order
 */
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


        private double subtotal;
        /// <summary>
        /// the subtotal of the order
        /// </summary>
        public double Subtotal { 
            get 
            { 
                subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                
                
                return subtotal;
            }

            private set { subtotal = value; } 
        
        }


        private double total;

        public double Total
        {
            get
            {
                return subtotal * 1.16;
            }

           
        }


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
            if (item is INotifyPropertyChanged notifier)
            { 
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            
            items.Add(item);           
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                       
        }

        /// <summary>
        /// the method to remove item from the order
        /// </summary>
        /// <param name="item">the item removed from</param>
        public void Remove(IOrderItem item) 
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
           
            items.Remove(item);            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal" +
                ""));

        }


        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
