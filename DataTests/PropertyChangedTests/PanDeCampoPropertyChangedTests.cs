using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class PanDeCampoPropertyChangedTests
    {
        /// <summary>
        /// Implement
        /// </summary>
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Small;
            });
        }
    }
}
