using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        public double Price {
            get { return 5.99; }
        }

        public uint Calories {
            get { return 190; }
        }

        private bool pickle = true;

        public bool Pickle {
            get { return pickle; }
            set { pickle = value; }
        }
    }
}
