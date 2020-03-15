/*
 * Author: Aruhan
 * Class: AngryChicken.cs
 * Purpose: the class create Angry Chicken entree
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the angry chicken
        /// </summary>
        public override double Price {
            get { return 5.99; }
        }
        
        /// <summary>
        /// The calories of the angry chicken
        /// </summary>
        public override uint Calories {
            get { return 190; }
        }

        /// <summary>
        /// If the angry chicken shoud be served with pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the angry chicken shoud be served with pickle
        /// </summary>
        public bool Pickle {
            get { return pickle; }
            set { pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }


        private bool bread = true;
        /// <summary>
        /// If the angry chicken should be served with bread
        /// </summary>
        public bool Bread {
            get { return bread; }
            set {
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                List<string> instructions = new List<string>();
                if (!Bread)
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
        /// <returns>The string describing the angry chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }

    }
}
