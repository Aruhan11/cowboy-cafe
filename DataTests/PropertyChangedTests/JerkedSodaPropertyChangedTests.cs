using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class JerkedSodaPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void JerkedSodaShouldImplementINotifyPropertyChanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = Size.Small;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingFlavorShouldInvokePropertyChangedForSize()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Flavor", () =>
            {
                soda.Flavor = SodaFlavor.CreamSoda;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingIceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = false;
            });
        }

    }
}
