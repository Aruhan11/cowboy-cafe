﻿/*
 * Author: Aruhan
 * Class: OrderControl.xaml.cs
 * Purpose: show the interface
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
using CowboyCafe.Data;
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        /// <summary>
        /// defalut set
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            DataContext = new Order();
        }

      
        public void ItemSelectionClick(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }
        
        
        /// <summary>
        /// Click event for cancel order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            DataContext = new Order(); 
        }

        /// <summary>
        /// Click event for cpmplete order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CompleteOrderClick(object sender, RoutedEventArgs e)
        {
            var mainWindow = this.FindAncestor<MainWindow>();

            var order = this.DataContext;

            var screen = new TransactionControl();
            screen.DataContext = order;
            
            mainWindow.SwapScreen(screen);

             
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

      
    }
}
