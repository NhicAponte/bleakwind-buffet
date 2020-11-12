/*
 * Author: Nhicolas Aponte 
 * Class: Menu.cs 
 * Purpose: the Menu.cs class in the Data library
 */
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public static class Menu 
    {


        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entreeList = new List<IOrderItem>();

            BriarheartBurger b = new BriarheartBurger();
            entreeList.Add(b);

            DoubleDraugr dd = new DoubleDraugr();
            entreeList.Add(dd);

            GardenOrcOmelette g = new GardenOrcOmelette();
            entreeList.Add(g);

            PhillyPoacher p = new PhillyPoacher();
            entreeList.Add(p);

            SmokehouseSkeleton s = new SmokehouseSkeleton();
            entreeList.Add(s);

            ThalmorTriple tt = new ThalmorTriple();
            entreeList.Add(tt);

            ThugsTBone thu = new ThugsTBone();
            entreeList.Add(thu); 

            return entreeList; 
        }  
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sideList = new List<IOrderItem>();

            foreach (Size s in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dr = new DragonbornWaffleFries(); 
                dr.Size = s;
                sideList.Add(dr);

                FriedMiraak f = new FriedMiraak();
                f.Size = s;
                sideList.Add(f);

                MadOtarGrits mo = new MadOtarGrits();
                mo.Size = s;
                sideList.Add(mo);

                VokunSalad v = new VokunSalad();
                v.Size = s;
                sideList.Add(v);
            }
            return sideList; 
        }      
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>(); 

            //could get rid of foreach loop and just use different vars for Size 
            foreach(Size s in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aj = new AretinoAppleJuice(); 
                aj.Size = s;
                drinkList.Add(aj);

                CandlehearthCoffee cc = new CandlehearthCoffee(); 
                cc.Size = s;
                drinkList.Add(cc); 

                CandlehearthCoffee dc = new CandlehearthCoffee(); 
                dc.Size = s;
                dc.Decaf = true; 
                drinkList.Add(dc);

                MarkarthMilk mm = new MarkarthMilk(); 
                mm.Size = s;
                drinkList.Add(mm);

                foreach(SodaFlavor f in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda ss = new SailorSoda();
                    ss.Size = s;
                    ss.Flavor = f; 
                    drinkList.Add(ss); 

                }

                WarriorWater w = new WarriorWater(); 
                w.Size = s;
                drinkList.Add(w);
            }
            return drinkList; 
        }

        public static List<IOrderItem> menuItems = new List<IOrderItem>();
        public static IEnumerable<IOrderItem> FullMenu()
        {
            //List<IOrderItem> fullList = new List<IOrderItem>();
            
            menuItems.AddRange(Sides());
            menuItems.AddRange(Entrees());
            menuItems.AddRange(Drinks()); 

            return menuItems; 
        } 

        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } } 
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if(terms == null)
            {
                return All; 
            }

            foreach(IOrderItem item in All)
            {
                if(item.Name.Contains(terms)) // StringComparison.CurrentCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            
            return results; 
        }

        public static string[] Categories
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menuItems, IEnumerable<string> category)
        {
            if(category == null || category.Count() == 0)
            {
                return menuItems; 
            }
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in menuItems)
            {

                if (Entrees().Contains(item))
                {
                    results.Add(item);
                }
                if (Drinks().Contains(item))
                {
                    results.Add(item);
                }
                if (Sides().Contains(item))
                {
                    results.Add(item);
                }
            }
            return results; 
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, uint? min, uint? max)
        {
            if(min == null && max == null)
            {
                return items;
            }
            var results = new List<IOrderItem>(); 
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if(item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results; 
            }
            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if(item.Calories >= min)
                    {
                        results.Add(item); 
                    }
                }
                return results; 
            }
            foreach(IOrderItem item in items)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results; 
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if(min == null && max == null)
            {
                return items;
            }
            var results = new List<IOrderItem>(); 
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if(item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results; 
            }
            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if(item.Price >= min)
                    {
                        results.Add(item); 
                    }
                }
                return results; 
            }
            foreach(IOrderItem item in items)
            {
                if(item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results; 
        }
    }
}
