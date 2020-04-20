/*
 * Author: Aruhan
 * Class: TransactionControl.xaml.cs
 * Propose: to process transaction
 * 
 */
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

       /// <summary>
       /// which payment
       /// </summary>
        private string payment; 

        /// <summary>
        /// helper method to print reciept
        /// </summary>
        /// <returns></returns>
        private string PrintHelper()
        {
            string recipt = "";

            string items = "";

            string specialInstructions;

            if (DataContext is Order order)
            {
                
                
                foreach (IOrderItem item in order.Items)
                {
                    specialInstructions = "";
                    
                    if(item.SpecialInstructions != null)
                    {
                        foreach (string instructions in item.SpecialInstructions)
                        {
                            specialInstructions += instructions;
                            specialInstructions += " ";
                        }

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

        /// <summary>
        /// event handler to process payment is credit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    mainWindow.SwapScreen(screen);

                }
                if (result == ResultCode.InsufficentFunds)
                {
                    MessageBox.Show("There is InsufficentFunds error.");
                }
                
                if (result == ResultCode.CancelledCard)
                {
                    MessageBox.Show("There is Cancelled Card error.");
                }
                if (result == ResultCode.ReadError)
                {
                    MessageBox.Show("There is Read error");
                }
                if (result == ResultCode.UnknownErrror)
                {
                    MessageBox.Show("There is UnknownError");
                }

            }
        }

        /// <summary>
        /// event handler to process when payment is cash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPaymentByCash(object sender, RoutedEventArgs e)
        {
            payment = "Pay by Cash";
            var cashDrawer = new CashRegister.CashDrawer();
            var mainWindow = this.FindAncestor<MainWindow>();
            var screen = new CashRegisterDrawer();            
            mainWindow.SwapScreen(screen);




        }

        /// <summary>
        /// event handler to process when cancel transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelTransaction(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
