using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Small;
            });
        }

    }
}
