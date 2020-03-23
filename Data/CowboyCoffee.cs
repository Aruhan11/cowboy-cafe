/*
 * Author: Aruhan
 * Class: CowboyCoffee.cs
 * Purpose: the class create cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the cowboy coffee drink
    /// </summary>
    public class CowboyCoffee: Drink, INotifyPropertyChanged
    {
             
        private bool roomForCream = false;
        
        /// <summary>
        /// If the cowboy coffee shoud be served with room for cream
        /// </summary>
        public bool RoomForCream 
        {
            get
            {   return roomForCream;    }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChange("RoomForCream");
            }
        }


        private bool ice = false;

        /// <summary>
        /// If the cowboy coffee shoud be served with ice
        /// </summary>
        public bool Ice 
        {
            get
            {
                return ice;
            }
            set
            {   
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        private  bool decaf = false;
        
        /// <summary>
        /// If the cowboy coffee shoud be served with decaf
        /// </summary>
        public  bool Decaf 
        {
            get { return decaf; }
            set 
            {
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        } 

        /// <summary>
        /// The price of Cowboy Coffee for different sizes
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The calories of Cowboy Coffee for different sizes
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the cowboy coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)
                {
                    instructions.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }
                

                return instructions;

            }
        }

        /// <summary>
        /// Return the strig representation of this object
        /// </summary>
        /// <returns>The string describing the cowboy coffee</returns>
        public override string ToString()
        {
            switch (Decaf)
            {                
                case true:
                    return Size.ToString() + " Decaf Cowboy Coffee";
                case false:
                    return Size.ToString() + " Cowboy Coffee";
                default:
                    throw new NotImplementedException();
            }
        
        }


    }
}
