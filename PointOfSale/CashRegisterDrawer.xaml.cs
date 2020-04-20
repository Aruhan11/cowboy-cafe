using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using Extensions;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterDrawer.xaml
    /// </summary>
    public partial class CashRegisterDrawer : UserControl
    {
        public CashRegisterDrawer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler to process when complete payment by cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompletePaymentByCash(object sender, RoutedEventArgs e)
        {
            var mainWindow = this.FindAncestor<MainWindow>();
            var screen = new OrderControl();
            mainWindow.SwapScreen(screen);
        }
    }
}
