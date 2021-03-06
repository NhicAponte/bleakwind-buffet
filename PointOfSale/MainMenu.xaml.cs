﻿/* Author: Nhicolas Aponte 
 * Class Name: MainMenu.xaml.cs 
 * Purpose: Class used to represent Main Menu screen and its properties 
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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl
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
                return (OrderControl) parent; 
            }
        }
        public MainMenu()
        {
            InitializeComponent();
            entreeButton.Click += EntreeScreen;
            sideButton.Click += SideScreen;
            drinkButton.Click += DrinkScreen; 
        }
        void EntreeScreen(object sender, RoutedEventArgs e)
        {
            OrderControl.screenBorder.Child = new EntreeMenu(); 
        }
        void SideScreen(object sender, RoutedEventArgs e)
        {
            OrderControl.screenBorder.Child = new SideMenu(); 
        }
        void DrinkScreen(object sender, RoutedEventArgs e)
        {
            OrderControl.screenBorder.Child = new DrinkMenu(); 
        }
    }
}
