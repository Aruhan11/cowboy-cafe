/*
 * Author: Aruhan
 * Class: ChiliCheeseFries.cs
 * Purpose: the class create Chili Chesse Fries side
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Chili Chesse Fries side
    /// </summary>
    public class ChiliCheeseFries: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The calories of chili chesse fries for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                } 
            }
        }

        /// <summary>
        /// The price of chili chesse fries for different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }        
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the chili cheese fries</returns>
        public override string ToString()
        {       
            return Size.ToString() + " Chili Cheese Fries";
        }

    }
}
