using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class RustlersRibsPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void RustlersRibsShouldImplementINotifyPropertyChanged()
        {
            var ribs = new RustlersRibs();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ribs);
        }

       
    }
}
