/* Author: Nhicolas Aponte 
 * Class Name: BriarheartBurgerScreen.xaml.cs 
 * Purpose: Class used to represent Briarheart Burger Screen and its properties 
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for BriarheartBurgerScreen.xaml
    /// </summary>
    public partial class BriarheartBurgerScreen : UserControl
    {
        private OrderControl OrderControl
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
        public BriarheartBurgerScreen()
        {
            InitializeComponent();
            doneButton.Click += EntreeScreen; 
        }

        void EntreeScreen(object sender, RoutedEventArgs e)
        {
            //var item = new IOrderItem();
            OrderControl.screenBorder.Child = new EntreeMenu();
        }
        /*
        void AddItem(object sender, RoutedEventArgs e)
        {
            var b = new BriarheartBurger();
            BriarheartBurgerScreen.DataContextProperty = b; 
        }*/
    }
}
