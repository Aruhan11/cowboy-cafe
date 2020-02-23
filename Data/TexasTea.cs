/*
 * Author: Aruhan
 * Class: TexasTea.cs
 * Purpose: the class create Texas Tea drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// if sever sweet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// if serve lemon or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// the price of Texas tea by different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// the calories of Texas tea by different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }

               
            }
        }

        /// <summary>
        /// the special instructions of Texas tea drink
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
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }

                return instructions;

            }
        }

        public override string ToString()
        {
            
            return Size.ToString() + "Texas Tea";
               

        }

    }
}
