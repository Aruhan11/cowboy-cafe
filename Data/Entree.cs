using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class  of base class of Entree
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
