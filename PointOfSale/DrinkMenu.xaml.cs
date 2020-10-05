/* Author: Nhicolas Aponte 
 * Class Name: DrinkMenu.xaml.cs 
 * Purpose: Class used to represent Drink Menu screen and its properties 
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkMenu.xaml
    /// </summary>
    public partial class DrinkMenu : UserControl
    {
        private MainWindow mainWindow
        {
            get
            {
                DependencyObject parent = this;
                do
                {
                    parent = LogicalTreeHelper.GetParent(parent);
                } while (!(parent is null || parent is MainWindow));
                return (MainWindow)parent;
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
            mainWindow.screenBorder.Child = new CandlehearthCoffeeScreen();
        }
        void JuiceScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new AretinoAppleJuiceScreen();
        }
        void MilkScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new MarkarthMilkScreen();
        }
        void SodaScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new SailorSodaScreen();
        }
        void WaterScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new WarriorWaterScreen();
        }
        void MainMenuScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new MainMenu();
        }
    }
}
