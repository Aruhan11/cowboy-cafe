using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class DakotaDoubleBurgerPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void DakotaDoubleBurgerShouldImplementINotifyPropertyChanged()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dakota);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForBun()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Bun", () =>
            {
                dakota.Bun = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingBunShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Bun = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForKetchup()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Ketchup", () =>
            {
                dakota.Ketchup = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingKetchupShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Ketchup = false;
            });
        } 
        
       

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForMustard()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mustard", () =>
            {
                dakota.Mustard = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMustardShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mustard = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Pickle", () =>
            {
                dakota.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Pickle = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForCheese()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Cheese", () =>
            {
                dakota.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingCheeseShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Cheese = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForTomato()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Tomato", () =>
            {
                dakota.Tomato = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingTomatoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Tomato = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForLettuce()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Lettuce", () =>
            {
                dakota.Lettuce = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingLettuceShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Lettuce = false;
            });
        }


        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForMayo()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "Mayo", () =>
            {
                dakota.Mayo = false;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingMayoShouldInvokePropertyChangedForSpecialInstructions()
        {
            var dakota = new DakotaDoubleBurger();
            Assert.PropertyChanged(dakota, "SpecialInstructions", () =>
            {
                dakota.Mayo = false;
            });
        }


    }
}
