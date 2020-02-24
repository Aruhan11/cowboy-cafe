/*
 * Author: Aruhan
 * Class: PecosPulledPork.cs
 * Purpose: the class create Pecos Pulled Pork entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// The price of the pecos pulled pork
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// The calories of the pecos pulled pork
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// If the pecos pulled pork should be served with bread
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If the pecos pulled pork should be served with bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// If the pecos pulled pork should be served with pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the pecos pulled pork should be served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!bread)
                {
                    instructions.Add("hold bread");
                }
                if (!pickle)
                {
                    instructions.Add("hold pickle");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the pecos pulled pork</returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
