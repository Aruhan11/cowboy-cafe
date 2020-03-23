/*
 * 
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
using CowboyCafe.Data;
using Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;

            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonCliked;
            AddPandeCampoButton.Click += OnAddPandeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;

            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;


            
        }


        //  public void OnItemAddButonClicked(object sender, RoutedEventArgs e)
        //  {
        //     var orderControl = this.FindAnestor<OrderControl>();
        //      if (DataContext is Order order)
        //      {
        //         if (sender is Button button)
        //          {
        //             switch (button.Tag)
        //             { 
        //                 case "CowpokeChili":
        //        order.Add(new CowpokeChili());
        //        orderControl.SwapScreen(new CustomizeCowpokeChili());
        //        break;
        //            }
        //         }
        //     }
        //
        //  }

        public void AddItemAndOnCustomizationScreen(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expeted to be an Order instance");

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor 0f OrderControl exception");

                screen.DataContext = item;
                
                orderControl.SwapScreen(screen);                  
            }
            order.Add(item);

        }



        /// <summary>
        /// Click event to add Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Rustlers Ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new RustlersRibs();
                var screen = new CustomizeRustlersRibs();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTripleBurger();
                var screen = new CustomizeTrailBurger();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new ChiliCheeseFries();
                var screen = new CustomizeChiliCheeseFries();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonCliked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CornDodgers();
                var screen = new CustomizeCornDodgers();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Pan De Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPandeCampoButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new PanDeCampo();
                var screen = new CustomizePandeCampo();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new BakedBeans();
                var screen = new CustomizeBakedBeans();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new TexasTea();
                var screen = new CustomizeTexasTea();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }

        /// <summary>
        /// Click event to add Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(Object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var entree = new Water();
                var screen = new CustomizeWater();
                AddItemAndOnCustomizationScreen(entree, screen);
            }
        }
    }
}
