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
    /// Interaction logic for ThalmorTripleScreen.xaml
    /// </summary>
    public partial class ThalmorTripleScreen : UserControl
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
        public ThalmorTripleScreen()
        {
            InitializeComponent();
            backButton.Click += EntreeScreen; 
        }
        void EntreeScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new EntreeMenu();
        }
    }
}
