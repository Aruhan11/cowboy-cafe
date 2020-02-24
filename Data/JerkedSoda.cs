/*
 * Author: Aruhan
 * Class: JerkedSoda.cs
 * Purpose: the class create Jerked Soda drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing Jerked Soda drink
    /// </summary>
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// the flavor
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// the price of jerked soda by different size
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories of jerked soda by differents size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the secial instructions of jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
               
                return instructions;

            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the Jerked Soda</returns>
        public override string ToString()
        {
            switch (Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size.ToString() + " Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size.ToString() + " Cream Soda Jerked Soda";
                
                case SodaFlavor.OrangeSoda:
                    return Size.ToString() + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size.ToString() + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size.ToString() + " Sarsparilla Jerked Soda";
                default:
                    throw new NotImplementedException();
            }
        }


    }
}
