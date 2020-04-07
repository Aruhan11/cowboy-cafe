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
using Extensions;
using CowboyCafe.Data;
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();

            PaymentByCredit.Click += OnPaymentByCredit;
            PaymentByCash.Click += OnPaymentByCash;
            CancelTransaction.Click += OnCancelTransaction;
        }

        private OrderControl order;

        private string payment; 


        public string PrintHelper()
        {
            string recipt = "";

            string items = "";

            string specialInstructions;

            if (DataContext is Order order)
            {
                
                
                foreach (IOrderItem item in order.Items)
                {
                    specialInstructions = "";
                    
                    foreach (string instrucntions in item.SpecialInstructions)
                    {
                        specialInstructions += instrucntions;
                        specialInstructions += " ";
                    }
                    items += item.ToString() + "\n" +  item.Price.ToString() + "\n" + specialInstructions + "\n";
                }

                recipt = "Order " + order.OrderNumber.ToString() + "\n"
                        + "Current time: " + DateTime.Now
                        + "Items:\n" + items
                        + "Subtotal: " + order.Subtotal
                        + "Total: " + order.Total
                        + "Payment: " + payment
                        ;
            }
            return recipt;
        
        }

        public void OnPaymentByCredit(object sender, RoutedEventArgs e)
        {
            payment = "Pay by Credit";

            var cashRegisterCardTerminal = new CashRegister.CardTerminal();
            var cashRegisterReceiptPrinter = new CashRegister.ReceiptPrinter();

            if (DataContext is Order order)
            {
                
                var result = cashRegisterCardTerminal.ProcessTransaction(order.Total);

                if (result == ResultCode.Success)
                {
                    cashRegisterReceiptPrinter.Print(PrintHelper());
                    var mainWindow = this.FindAncestor<MainWindow>();
                    var screen = new OrderControl();
                    screen.DataContext = new Order();
                    mainWindow.SwapScreen(screen);

                }
                if (result == ResultCode.InsufficentFunds)
                {
                    MessageBox.Show("There is/are error(s)");
                }
                
                if (result == ResultCode.CancelledCard)
                {
                    MessageBox.Show("There is/are error(s)");
                }
                if (result == ResultCode.ReadError)
                {
                    MessageBox.Show("There is/are error(s)");
                }
                if (result == ResultCode.UnknownErrror)
                {
                    MessageBox.Show("There is/are error(s)");
                }

            }
        }


        public void OnPaymentByCash(object sender, RoutedEventArgs e)
        {
            payment = "Pay by Cash";
            var cashDrawer = new CashRegister.CashDrawer();

            var mainWindow = this.FindAncestor<MainWindow>();
            var screen = new CashRegisterControl();            
            mainWindow.SwapScreen(screen);




        }


        public void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
