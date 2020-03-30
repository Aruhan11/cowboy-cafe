using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class TrailBurgerPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void TrailBurgerShouldImplementINotifyPropertyChanged()
        {
            var trail = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trail);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Bun", () =>
            {
                trail.Bun = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Bun = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Ketchup", () =>
            {
                trail.Ketchup = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Ketchup = false;
            });
        }



        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Mustard", () =>
            {
                trail.Mustard = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Mustard = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Pickle", () =>
            {
                trail.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "Cheese", () =>
            {
                trail.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var trail = new TrailBurger();
            Assert.PropertyChanged(trail, "SpecialInstructions", () =>
            {
                trail.Cheese = false;
            });
        }
    }
}
