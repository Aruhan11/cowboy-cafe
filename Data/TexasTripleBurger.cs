using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        public double Price
        {
            get { return 6.45; }
        }

        public uint Calories
        {
            get { return 698; }
        }

        private bool bacon = true;

        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;

        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
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
