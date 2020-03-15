/*
 * Author: Aruhan
 * Class: CornDodgers.cs
 * Purpose: the class create Corn Dodgers side
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers: Side, INotifyPropertyChanged
    {
        /// <summary>
        /// The calories of Corn Dodgers for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }


            }
        }

        /// <summary>
        /// The price of Corn Dodgers for different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the corn dodgers</returns>
        public override string ToString()
        {
            return Size.ToString() + " Corn Dodgers";
        }

    }
}
