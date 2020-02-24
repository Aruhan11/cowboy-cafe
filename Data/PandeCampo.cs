/*
 * Author: Aruhan
 * Class: PanDeCampo.cs
 * Purpose: the class create Pan de Campo side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// The calories of Pan de Campo for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of Pan de Campo for different sizes
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
        /// <returns>The string describing the pan de campo</returns>
        public override string ToString()
        {
            return Size.ToString() + " Pan de Campo";
        }
    }
}
