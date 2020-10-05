/* Author: Nhicolas Aponte 
 * Class Name: MadOtarGritsScreen.xaml.cs 
 * Purpose: Class used to represent Mad Otar Grits Screen and its properties 
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
    /// Interaction logic for MadOtarGritsScreen.xaml
    /// </summary>
    public partial class MadOtarGritsScreen : UserControl
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
        public MadOtarGritsScreen()
        {
            InitializeComponent();
            backButton.Click += SideScreen;

        }

        void SideScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new SideMenu();
        }

    }
}
