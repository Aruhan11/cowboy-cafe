/*
 * Author: Aruhan
 * Class: DakotaDoubleBurger.cs
 * Purpose: the class create Dakota Double Burger entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Dakota Double Burger entree
    /// </summary>
    public class DakotaDoubleBurger : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// The price of the dakota double burger
        /// </summary>
        public override double Price
        {
            get { return 5.20; }
        }

        /// <summary>
        /// The calories of the dakota double burger
        /// </summary>
        public override uint Calories
        {
            get { return 464; }
        }

        /// <summary>
        /// If the dakota double burger should be served with bun
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the dakota double burger should be served with bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If the dakota double burger should be served with ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the dakota double burger should be served with mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the dakota double burger should be served with pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the dakota double burger should be served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// If the dakota double burger should be served with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// If the dakota double burger should be served with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        /// <summary>
        /// If the dakota double burger should be served with mayo
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// If the dakota double burger should be served with mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the double burger
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
                
                return instructions;
            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the dakota double burger</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
