/*
 * Author: Aruhan
 * Class: MenuTests.cs
 */
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// a test class to test menu
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// test for entrees property
        /// </summary>
        [Fact]
        public void CheckEntreesProperty()
        {
            Assert.Collection(
                Menu.Entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );                          
        }

        /// <summary>
        /// test for side property
        /// </summary>
        [Fact]
        public void CheckSidesProperty()
        {
            Assert.Collection(
                Menu.Entrees,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }             
                );
        }

        /// <summary>
        /// test for drink property
        /// </summary>
        [Fact]
        public void CheckDrinksProperty()
        {
            Assert.Collection(
                 Menu.Entrees,
                 (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                 (js) => { Assert.IsType<JerkedSoda>(js); },
                 (tt) => { Assert.IsType<TexasTea>(tt); },
                 (w) => { Assert.IsType<Water>(w); }
                 );            
        }

        /// <summary>
        /// test for search method
        /// </summary>
        [Fact]
        public void CheckSearchMethod()
        {
            IEnumerable<IOrderItem> items = Menu.Search(Menu.All, "");
            Assert.Equal(items, Menu.All);
        }

        /// <summary>
        /// test for filter by category
        /// </summary>
        [Fact]
        public void CheckFilterByCategory()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCategory(null, null);
            Assert.Equal(items, Menu.All);
        }

        /// <summary>
        /// test for filter by calories
        /// </summary>
        [Fact]
        public void CheckFilterByCalories()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCalories(null, null, null);
            Assert.Equal(items, Menu.All);
        }

        /// <summary>
        /// test for filter by price
        /// </summary>
        [Fact]
        public void CheckFilterByPrice()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByPrice(null, null, null);
            Assert.Equal(items, Menu.All);
        }

    }
}
