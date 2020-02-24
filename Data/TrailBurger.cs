﻿/*
 * Author: Aruhan
 * Class: TrailBurger.cs
 * Purpose: the class create Trail Burger entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Trail Burger entree
    /// </summary>
    public class TrailBurger: Entree
    {
        /// <summary>
        /// The price of the trail burger
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }

        /// <summary>
        /// The calories of the trail burger
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }

        /// <summary>
        /// If the trail burger should be served with bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the trail burger should be served with bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// If the trail burger should be served with ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If the trail burger should be served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// If the trail burger should be served with mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the trail burger should be served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// If the trail burger should be served with pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the trail burger should be served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the trail burger should be served with cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the trail burger should be served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!bun)
                {
                    instructions.Add("hold bun");
                }
                if (!ketchup)
                {
                    instructions.Add("hold ketchup");
                }
                if (!mustard)
                {
                    instructions.Add("hold mustard");
                }
                if (!pickle)
                {
                    instructions.Add("hold pickle");
                }
                if (!cheese)
                {
                    instructions.Add("hold cheese");
                }
                return instructions;
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the trail burger</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }

    }
}
