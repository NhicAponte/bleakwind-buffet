/* Author: Nhicolas Aponte 
 * Class Name: SideMenu.xaml.cs 
 * Purpose: Class used to represent Side Menu screen and its properties 
 */

using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
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
        public SideMenu()
        {
            InitializeComponent();
            mainMenuButton.Click += MainMenuScreen;
            friesButton.Click += WaffleFriesScreen;
            miraakButton.Click += MiraakScreen;
            gritsButton.Click += GritsScreen;
            saladButton.Click += SaladScreen; 
        }
        void MainMenuScreen(object sender, RoutedEventArgs e)
        {
            orderControl.screenBorder.Child = new MainMenu();
        }
        void WaffleFriesScreen(object sender, RoutedEventArgs e)
        {
            var ds = new DragonbornWaffleFriesScreen();
            ds.DataContext = new DragonbornWaffleFries();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ds.DataContext);
            }
            orderControl.screenBorder.Child = ds;
        }   
        void MiraakScreen(object sender, RoutedEventArgs e)
        {
            var fs = new FriedMiraakScreen();
            fs.DataContext = new FriedMiraak();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)fs.DataContext);
            }
            orderControl.screenBorder.Child = fs;
        }    
        void GritsScreen(object sender, RoutedEventArgs e)
        {
            var mos = new MadOtarGritsScreen();
            mos.DataContext = new MadOtarGrits();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)mos.DataContext);
            }
            orderControl.screenBorder.Child = mos;
        }    
        void SaladScreen(object sender, RoutedEventArgs e)
        {
            var vs = new VokunSaladScreen();
            vs.DataContext = new VokunSalad();

            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)vs.DataContext);
            }
            orderControl.screenBorder.Child = vs; 
        }
    }
}
