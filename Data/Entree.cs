/*
 * Author: Aruhan
 * Class: Entree.cs
 * Purpose: the class create the base class of entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class of base class of Entree
    /// </summary>
    public abstract class Entree: IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// The special instructions of entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }


        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
