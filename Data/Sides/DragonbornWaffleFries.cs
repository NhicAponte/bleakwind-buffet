using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: DragonbornWaffleFries.cs 
 * Purpose: Class used to represent Dragonborn Waffle Fries and its properties 
 */

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// assigns value for size 
        /// </summary>
        private Size size = Size.Small; 
        public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        /// <summary>
        /// assigns value for price 
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.42;
                if (size == Size.Medium) return 0.76;
                if (size == Size.Large) return 0.96;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// assigns value for calories 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 77;
                if (size == Size.Medium) return 89;
                if (size == Size.Large) return 100; 
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// returns blank list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();

        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// displays dragonborn waffle fries with its size 
        /// </summary>
        /// <returns>string "{Size} Dragonborn Waffle Fries"</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
