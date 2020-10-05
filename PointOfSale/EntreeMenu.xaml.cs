/* Author: Nhicolas Aponte 
 * Class Name: EntreeMenu.xaml.cs 
 * Purpose: Class used to represent Entree Menu and its properties 
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
    /// Interaction logic for EntreeMenu.xaml
    /// </summary>
    public partial class EntreeMenu : UserControl
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
        public EntreeMenu()
        {
            InitializeComponent();
            briarheartButton.Click += BriarheartScreen;
            draugrButton.Click += DraugrScreen;
            orcButton.Click += orcOmeletteScreen;
            phillyButton.Click += PhillyScreen;
            skeletonButton.Click += SkeletonScreen;
            tboneButton.Click += TBoneScreen;
            thalmorButton.Click += ThalmorScreen;
            mainMenuButton.Click += MainMenuScreen; 
        }
        void BriarheartScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new BriarheartBurgerScreen();
        }
        void DraugrScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new DoubleDraugrScreen();
        }
        void orcOmeletteScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new GardenOrcOmeletteScreen();
        }
        void PhillyScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new PhillyPoacherScreen();
        }
        void SkeletonScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new SmokehouseSkeletonScreen();
        }
        void TBoneScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new ThugsTBoneScreen();
        }
        void ThalmorScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new ThalmorTripleScreen();
        }    
        void MainMenuScreen(object sender, RoutedEventArgs e)
        {
            mainWindow.screenBorder.Child = new MainMenu();
        }
    }
}
