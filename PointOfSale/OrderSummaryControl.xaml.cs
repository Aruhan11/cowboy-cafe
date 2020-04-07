/*
 * Author: Aruhan
 * Class: OrderSummaryControl.xaml.cs
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {

        private OrderControl order;
        
        /// <summary>
        /// defalut set
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Romove items in order list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveItem(object sender, RoutedEventArgs e)
        {
           if(DataContext is Order order)
            
            if (sender is FrameworkElement element)
            {
                if (element.DataContext is IOrderItem item)
                {
                    order.Remove(item);                   
                }                                    
            } 
        }

        /// <summary>
        /// Change selection for items
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSlection(Object sender, RoutedEventArgs e)
        {
            if (sender is ListBox list)
            {
                if (list.SelectedItem is IOrderItem OrderItem)
                {
                    if (OrderItem is AngryChicken angryChiken)
                    {
                        var screen = new CustomizeAngryChicken();
                        screen.DataContext = angryChiken;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is BakedBeans bakedBeans)
                    {
                        var screen = new CustomizeBakedBeans();
                        screen.DataContext = bakedBeans;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is ChiliCheeseFries chiliCheseFries)
                    {
                        var screen = new CustomizeChiliCheeseFries();
                        screen.DataContext = chiliCheseFries;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CornDodgers cornDodgers)
                    {
                        var screen = new CustomizeCornDodgers();
                        screen.DataContext = cornDodgers;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CowboyCoffee cowboyCoffee)
                    {
                        var screen = new CustomizeCowboyCoffee();
                        screen.DataContext = cowboyCoffee;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is CowpokeChili cowpokeChili)
                    {
                        var screen = new CustomizeCowpokeChili();
                        screen.DataContext = cowpokeChili;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is DakotaDoubleBurger dakotaDoubleBurger)
                    {
                        var screen = new CustomizeDakotaDoubleBurger();
                        screen.DataContext = dakotaDoubleBurger;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is JerkedSoda jerkedSoda)
                    {
                        var screen = new CustomizeJerkedSoda();
                        screen.DataContext = jerkedSoda;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is PanDeCampo panDeCampo)
                    {
                        var screen = new CustomizePandeCampo();
                        screen.DataContext = panDeCampo;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is PecosPulledPork pecosPulledPork)
                    {
                        var screen = new CustomizePecosPulledPork();
                        screen.DataContext = pecosPulledPork;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is RustlersRibs rustlersRibs)
                    {
                        var screen = new CustomizeRustlersRibs();
                        screen.DataContext = rustlersRibs;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TexasTea texasTea)
                    {
                        var screen = new CustomizeTexasTea();
                        screen.DataContext = texasTea;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TexasTripleBurger texasTripleBurger)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = texasTripleBurger;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is TrailBurger trailBurger)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = trailBurger;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }
                    if (OrderItem is Water water)
                    {
                        var screen = new CustomizeTexasTripleBurger();
                        screen.DataContext = water;
                        order = this.FindAncestor<OrderControl>();
                        order.SwapScreen(screen);
                    }

                }
            }
        }
    }
}
