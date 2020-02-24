/*
 * Author: Aruhan
 * Class: RustlersRibs.cs
 * Purpose: the class create Rustler's Ribs entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// The price of the rustler's ribs
        /// </summary>
        public override double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calories of the rustler's ribs
        /// </summary>
        public override uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();            
                return instructions;
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the rustler's ribs</returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }

    }
}
