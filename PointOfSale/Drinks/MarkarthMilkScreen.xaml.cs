﻿/* Author: Nhicolas Aponte 
 * Class Name: MarkarthMilkScreen.xaml.cs 
 * Purpose: Class used to represent Markarth Milk Screen and its properties 
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
    /// Interaction logic for MarkarthMilkScreen.xaml
    /// </summary>
    public partial class MarkarthMilkScreen : UserControl
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
        public MarkarthMilkScreen()
        {
            InitializeComponent();
            doneButton.Click += DrinkScreen;
        }

        void DrinkScreen(object sender, RoutedEventArgs e)
        {
            OrderControl.screenBorder.Child = new DrinkMenu();
        }
    }
}
