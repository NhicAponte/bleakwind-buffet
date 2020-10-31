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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeMenu.xaml
    /// </summary>
    public partial class EntreeMenu : UserControl
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
            BriarheartBurgerScreen bbs = new BriarheartBurgerScreen();
            bbs.DataContext = new BriarheartBurger(); 

            if(orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)bbs.DataContext); 
            }
            orderControl.screenBorder.Child = bbs;

            //can I add the item already edited with the add item button 
        }
        void DraugrScreen(object sender, RoutedEventArgs e)
        {
            var ds = new DoubleDraugrScreen();
            ds.DataContext = new DoubleDraugr(); 

            if(orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ds.DataContext); 
            }
            orderControl.screenBorder.Child = ds;
        }
        void orcOmeletteScreen(object sender, RoutedEventArgs e)
        {
            var gs = new GardenOrcOmeletteScreen();
            gs.DataContext = new GardenOrcOmelette();
            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)gs.DataContext);
            }
            orderControl.screenBorder.Child = gs;
        }
        void PhillyScreen(object sender, RoutedEventArgs e)
        {
            var ps = new PhillyPoacherScreen();
            ps.DataContext = new PhillyPoacher();
            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ps.DataContext);
            }
            orderControl.screenBorder.Child = ps;
        }
        void SkeletonScreen(object sender, RoutedEventArgs e)
        {
            var ss = new SmokehouseSkeletonScreen();
            ss.DataContext = new SmokehouseSkeleton();
            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ss.DataContext);
            }
            orderControl.screenBorder.Child = ss;
        }
        void TBoneScreen(object sender, RoutedEventArgs e)
        {
            var ths = new ThugsTBoneScreen();
            ths.DataContext = new ThugsTBone();
            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ths.DataContext);
            }
            orderControl.screenBorder.Child = ths;
        }
        void ThalmorScreen(object sender, RoutedEventArgs e)
        {
            var ts = new ThalmorTripleScreen();
            ts.DataContext = new ThalmorTriple();
            if (orderControl.DataContext is Order order)
            {
                order.Add((IOrderItem)ts.DataContext);
            }
            orderControl.screenBorder.Child = ts;
        }    
        void MainMenuScreen(object sender, RoutedEventArgs e)
        {
            orderControl.screenBorder.Child = new MainMenu();
        }
    }
}
