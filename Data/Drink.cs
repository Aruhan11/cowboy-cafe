/*
 * Author: Aruhan
 * Class: Drink.cs
 * Purpose: the class create base class of drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class of base class of drink
    /// </summary>
    public abstract class Drink: IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// the price of drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// the calories of drink
        /// </summary>
        public abstract uint Calories { get; }


        private Size size;

        /// <summary>
        /// the size of drink
        /// </summary>
        public virtual Size Size 
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        private bool ice = true;

        /// <summary>
        /// if serve ice for drink
        /// </summary>
        public bool Ice 
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        } 


        /// <summary>
        /// the special instructions of 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }
}
