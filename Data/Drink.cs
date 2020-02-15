/*
 * Author: Aruhan
 * Class: Drink.cs
 * Purpose: the class create base class of drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class of base class of drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// the price of drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// the calories of drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// the size of drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// if serve ice for drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;


        /// <summary>
        /// the special instructions of 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

    }
}
