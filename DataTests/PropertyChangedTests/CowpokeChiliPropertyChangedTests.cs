using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CowpokeChiliPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void CowpokeChiliShouldImplementINotifyPropertyChanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingSourCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingGreenOnionsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTortillaStripsShouldInvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }


    }
}
