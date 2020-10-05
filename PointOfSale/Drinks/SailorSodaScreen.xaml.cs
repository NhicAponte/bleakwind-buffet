/* Author: Nhicolas Aponte 
 * Class Name: SailorSodaScreen.xaml.cs 
 * Purpose: Class used to represent Sailor Soda Screen and its properties 
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
    /// Interaction logic for SailorSodaScreen.xaml
    /// </summary>
    public partial class SailorSodaScreen : UserControl
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
        public SailorSodaScreen()
        {
            InitializeComponent();
            backButton.Click += DrinkScreen;
        }

        void DrinkScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new DrinkMenu();
        }
    }
}
