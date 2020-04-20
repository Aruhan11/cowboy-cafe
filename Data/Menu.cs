/*
 * Author: Aruhan
 * Class: Menu.cs
 * Propose: represent menus
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a class representing a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// menu of entree
        /// </summary>
        /// <returns>the list of entree</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
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

        /// <summary>
        /// menu of sides
        /// </summary>
        /// <returns>a list of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
           
            return sides;
        }

        /// <summary>
        /// menu of drinks
        /// </summary>
        /// <returns>a list of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            
            return drinks;
        }

        /// <summary>
        /// menu of all
        /// </summary>
        /// <returns> a list of menu all</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
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
}
