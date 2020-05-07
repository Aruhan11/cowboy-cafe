/*
 * Author: Aruhan
 * Class: Menu.cs
 * Propose: represent menus
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// a list of entree
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees
        {
            get{
                List<IOrderItem> entrees = new List<IOrderItem>();
                entrees.Add(new AngryChicken());
                entrees.Add(new CowpokeChili());
                entrees.Add(new DakotaDoubleBurger());
                entrees.Add(new RustlersRibs());
                entrees.Add(new TrailBurger());
                entrees.Add(new TexasTripleBurger());
                entrees.Add(new PecosPulledPork());

                return entrees;

            }
           
        }

       /// <summary>
       /// a list of side
       /// </summary>
        public static IEnumerable<IOrderItem> Sides
        {
            get {
                List<IOrderItem> sides = new List<IOrderItem>();
                sides.Add(new BakedBeans());
                sides.Add(new ChiliCheeseFries());
                sides.Add(new CornDodgers());
                sides.Add(new PanDeCampo());

                return sides;
            }
           
        }

        /// <summary>
        /// a list of drink
        /// </summary>
        public static IEnumerable<IOrderItem> Drinks
        {
            get {
                List<IOrderItem> drinks = new List<IOrderItem>();
                drinks.Add(new CowboyCoffee());
                drinks.Add(new JerkedSoda());
                drinks.Add(new TexasTea());
                drinks.Add(new Water());

                return drinks;
            }
            
        }

        /// <summary>
        /// a list of all 
        /// </summary>
        public static IEnumerable<IOrderItem> All
        {
            get {
                List<IOrderItem> allMenu = new List<IOrderItem>();
                allMenu.Add(new AngryChicken());
                allMenu.Add(new CowpokeChili());
                allMenu.Add(new DakotaDoubleBurger());
                allMenu.Add(new RustlersRibs());
                allMenu.Add(new TrailBurger());
                allMenu.Add(new TexasTripleBurger());
                allMenu.Add(new PecosPulledPork());

                allMenu.Add(new BakedBeans());
                allMenu.Add(new ChiliCheeseFries());
                allMenu.Add(new CornDodgers());
                allMenu.Add(new PanDeCampo());

                allMenu.Add(new CowboyCoffee());
                allMenu.Add(new JerkedSoda());
                allMenu.Add(new TexasTea());
                allMenu.Add(new Water());

                return allMenu;

            }

        }

        /// <summary>
        /// Search method 
        /// </summary>
        /// <param name="orderItems">the list of order items</param>
        /// <param name="terms">the searched term</param>
        /// <returns>the list of order items after seaching</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();            
            if (terms == null) return orderItems;        
            foreach (IOrderItem item in orderItems)
            {
                if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    
                    results.Add(item);
                  
                }
            }
            return results;
        }

        /// <summary>
        /// a list of category
        /// </summary>
        public static string[] Category
        {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink",      
            };
        }

        /// <summary>
        /// filter by category
        /// </summary>
        /// <param name="orderItems">a list of order items</param>
        /// <param name="category">the category filtered</param>
        /// <returns>a list of order items after filtering by category</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> category)
        {
            
            if (category.Count() == 0) return orderItems;
           
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in orderItems)
            {
                if (item is Entree && category.Contains("Entree"))
                {
                    results.Add(item);
                }
                
                if (item is Side && category.Contains("Side"))
                {
                    results.Add(item);
                }
                
                if (item is Drink && category.Contains("Drink"))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// filter by calories
        /// </summary>
        /// <param name="orderItems">a list of order items</param>
        /// <param name="min">the mix value of calory</param>
        /// <param name="max">the max value of calory</param>
        /// <returns>a list of order items after filtering by calories </returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }

        /// <summary>
        /// filter by price
        /// </summary>
        /// <param name="orderItems">a list of order items</param>
        /// <param name="min">the min value of price</param>
        /// <param name="max">the max value of price</param>
        /// <returns>a list of order items after filtering by price</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in orderItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }


        /// <summary>
        /// a list of flavors
        /// </summary>
        public static string[] Flavor
        {
            get => new string[]
            {
             "CreamSoda",
             "OrangeSoda",
             "Sarsparilla",
             "BirchBeer",
             "RootBeer",
            };
        }

    }
}
