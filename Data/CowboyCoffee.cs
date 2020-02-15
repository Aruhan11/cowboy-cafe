/*
 * Author: Aruhan
 * Class: CowboyCoffee.cs
 * Purpose: the class create cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the cowboy coffee drink
    /// </summary>
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// If the cowboy coffee shoud be served with room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// If the cowboy coffee shoud be served with ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// If the cowboy coffee shoud be served with decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// The price of Cowboy Coffee for different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of Cowboy Coffee for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the cowboy coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }

                return instructions;

            }
        }


    }
}
