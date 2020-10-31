/* Author: Nhicolas Aponte 
 * Class Name: DoubleDraugrScreen.xaml.cs 
 * Purpose: Class used to represent Double Draugr Screen and its properties 
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
    /// Interaction logic for DoubleDraugrScreen.xaml
    /// </summary>
    public partial class DoubleDraugrScreen : UserControl
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
        public DoubleDraugrScreen()
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
