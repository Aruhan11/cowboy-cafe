/*
 * Author: Aruhan
 * Class: Side.cs
 * Purpose: the class create the base class of entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// the propery changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        

        private Size size;

        /// <summary>
        /// the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { 
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }      
        }
        
        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// category of side
        /// </summary>
        public string Category { get { return "Side"; } }


        /// <summary>
        /// Get the calories of the side
        /// </summary>
        public List<string> SpecialInstructions { get; }

    }
}
