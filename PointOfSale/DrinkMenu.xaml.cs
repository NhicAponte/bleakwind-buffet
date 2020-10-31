/* Author: Nhicolas Aponte 
 * Class Name: DrinkMenu.xaml.cs 
 * Purpose: Class used to represent Drink Menu screen and its properties 
 */

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkMenu.xaml
    /// </summary>
    public partial class DrinkMenu : UserControl
    {
        private OrderControl orderControl
        {
            get
            {
                DependencyObject parent = this;
                do
                {
                    parent = LogicalTreeHelper.GetParent(parent);
                } while (!(parent is null || parent is OrderControl));
                return (OrderControl)parent;
            }
        }
        public DrinkMenu()
        {
            InitializeComponent();
            juiceButton.Click += JuiceScreen;
            coffeeButton.Click += CoffeeScreen;
            milkButton.Click += MilkScreen;
            sodaButton.Click += SodaScreen;
            waterButton.Click += WaterScreen;
            mainMenuButton.Click += MainMenuScreen;
        }

        void CoffeeScreen(object sender, RoutedEventArgs e)
        {
            var cs = new CandlehearthCoffeeScreen();
            cs.DataContext = new CandlehearthCoffee();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)cs.DataContext);
            }
            orderControl.screenBorder.Child = cs;
        }
        void JuiceScreen(object sender, RoutedEventArgs e)
        {
            var ajs = new AretinoAppleJuiceScreen();
            ajs.DataContext = new AretinoAppleJuice();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ajs.DataContext);
            }
            orderControl.screenBorder.Child = ajs;
        }
        void MilkScreen(object sender, RoutedEventArgs e)
        {
            var mms = new MarkarthMilkScreen();
            mms.DataContext = new MarkarthMilk();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)mms.DataContext);
            }
            orderControl.screenBorder.Child = mms;
        }
        void SodaScreen(object sender, RoutedEventArgs e)
        {
            var sas = new SailorSodaScreen();
            sas.DataContext = new SailorSoda();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)sas.DataContext);
            }
            orderControl.screenBorder.Child = sas;
        }
        void WaterScreen(object sender, RoutedEventArgs e)
        {
            var ws = new WarriorWaterScreen();
            ws.DataContext = new WarriorWater();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ws.DataContext);
            }
            orderControl.screenBorder.Child = ws;
        }
        void MainMenuScreen(object sender, RoutedEventArgs e)
        {
            orderControl.screenBorder.Child = new MainMenu();
        }
    }
}
