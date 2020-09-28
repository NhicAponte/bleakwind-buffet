using BleakwindBuffet.Data.Sides;
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
            mainWindow.screenBorder.Child = new MainMenu();
        }
        void WaffleFriesScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new DragonbornWaffleFriesScreen(); 
        }   
        void MiraakScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new FriedMiraakScreen(); 
        }    
        void GritsScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new MadOtarGritsScreen(); 
        }    
        void SaladScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new VokunSaladScreen(); 
        }
    }
}
