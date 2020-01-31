using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger
    {
        public double Price
        {
            get { return 5.20; }
        }

        public uint Calories
        {
            get { return 464; }
        }

        private bool tomato = true;

        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        private bool lettuce = true;

        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        private bool mayo = true;

        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
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
    }
}
