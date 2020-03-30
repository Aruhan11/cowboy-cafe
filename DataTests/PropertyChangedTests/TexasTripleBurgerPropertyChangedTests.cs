using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TexasTripleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void TexasTripleBurgerShouldImplementINotifyPropertyChanged()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(texasBurger);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Bun", () =>
            {
                texasBurger.Bun = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Bun = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Ketchup", () =>
            {
                texasBurger.Ketchup = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Ketchup = false;
            });
        }



        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Mustard", () =>
            {
                texasBurger.Mustard = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Mustard = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Pickle", () =>
            {
                texasBurger.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Cheese", () =>
            {
                texasBurger.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Tomato", () =>
            {
                texasBurger.Tomato = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Tomato = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Lettuce", () =>
            {
                texasBurger.Lettuce = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Lettuce = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Mayo", () =>
            {
                texasBurger.Mayo = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Mayo = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForBacon()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Bacon", () =>
            {
                texasBurger.Bacon = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBaconShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Bacon = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForEgg()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "Egg", () =>
            {
                texasBurger.Egg = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingEggShouldInvokePropertyChangedForSpecialInstructions()
        {
            var texasBurger = new TexasTripleBurger();
            Assert.PropertyChanged(texasBurger, "SpecialInstructions", () =>
            {
                texasBurger.Egg = false;
            });
        }

    }
}
