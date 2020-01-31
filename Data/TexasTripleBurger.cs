﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger
    {
        /// <summary>
        /// The price of the texas triple burger
        /// </summary>
        public double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// The calories of the texas triple burger
        /// </summary>
        public uint Calories
        {
            get { return 698; }
        }

        /// <summary>
        /// If the texas triple burger should be served with bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the texas triple burger should be served with bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If the texas triple burger should be served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the texas triple burger should be served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the texas triple burger should be served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the texas triple burger should be served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// If the texas triple burger should be served with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// If the texas triple burger should be served with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// If the texas triple burger should be served with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with bacon
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// If the texas triple burger should be served with bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        /// <summary>
        /// If the texas triple burger should be served with egg
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// If the texas triple burger should be served with egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        ///  Special instructions for the preparation of the triple burger
        /// </summary>
        public List<string> SpecialInstructions
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
                if (!tomato)
                {
                    instructions.Add("hold tomato");
                }
                if (!lettuce)
                {
                    instructions.Add("hold lettuce");
                }
                if (!mayo)
                {
                    instructions.Add("hold mayo");
                }
                if (!bacon)
                {
                    instructions.Add("hold bacon");
                }
                if (!egg)
                {
                    instructions.Add("hold egg");
                }
               
                return instructions;
            }
        }

    }
}
