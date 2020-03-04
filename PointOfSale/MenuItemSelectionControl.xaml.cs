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

        /// <summary>
        /// Click event to add Cowpoke Chili
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(Object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CowpokeChili());
                               
            }
        }

        /// <summary>
        /// Click event to add Rustlers Ribs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(Object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new RustlersRibs());
            if (DataContext is Order data)
            {
                data.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Click event to add Pecos Pulled Pork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new PecosPulledPork());
            if (DataContext is Order data)
            {
                data.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Click event to add Trail Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new TrailBurger());
            if (DataContext is Order data)
            {
                data.Add(new TrailBurger());
            }
        }

        /// <summary>
        /// Click event to add Dakota Double Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new DakotaDoubleBurger());
            if (DataContext is Order data)
            {
                data.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// Click event to add Texas Triple Burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new TexasTripleBurger());
            if (DataContext is Order data)
            {
                data.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Click event to add Angry Chicken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(Object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new AngryChicken());
            if (DataContext is Order data)
            {
                data.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Click event to add Chili Cheese Fries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new ChiliCheeseFries());
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Click event to add Corn Dodgers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonCliked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new CornDodgers());
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Click event to add Pan De Campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPandeCampoButtonClicked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new PanDeCampo());
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Click event to add Baked Beans
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new BakedBeans());
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Click event to add Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new JerkedSoda());
            if (DataContext is Order data)
            {
                data.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Click event to add Texas Tea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(Object sender, RoutedEventArgs e)
        {
            // OrderListView.Items.Add(new TexasTea());
            if (DataContext is Order data)
            {
                data.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Click event to add Cowboy Coffee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new CowboyCoffee());
            if (DataContext is Order data)
            {
                data.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Click event to add Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(Object sender, RoutedEventArgs e)
        {
            //  OrderListView.Items.Add(new Water());
            if (DataContext is Order data)
            {
                data.Add(new Water());
            }
        }
    }
}
