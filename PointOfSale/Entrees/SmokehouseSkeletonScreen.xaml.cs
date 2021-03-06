﻿/* Author: Nhicolas Aponte 
 * Class Name: SmokehouseSkeletonScreen.xaml.cs 
 * Purpose: Class used to represent Smokehouse Skeleton Screen and its properties 
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
    /// Interaction logic for SmokehouseSkeletonScreen.xaml
    /// </summary>
    public partial class SmokehouseSkeletonScreen : UserControl
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
        public SmokehouseSkeletonScreen()
        {
            InitializeComponent();
            doneButton.Click += EntreeScreen;

        }
        void EntreeScreen(object sender, RoutedEventArgs e)
        {
            OrderControl.screenBorder.Child = new EntreeMenu();
        }
    }
}
