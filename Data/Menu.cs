using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
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

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
           
            return sides;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            
            return drinks;
        }

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
