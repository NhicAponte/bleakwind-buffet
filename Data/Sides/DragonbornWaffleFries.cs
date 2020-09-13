﻿/* Author: Nhicolas Aponte 
 * Class Name: DragonbornWaffleFries.cs 
 * Purpose: Class used to represent Dragonborn Waffle Fries and its properties 
 */ 

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries : Side 
    {
        /// <summary>
        /// assigns value for size 
        /// </summary>
        private Size size = Size.Small; 
        /// <summary>
        /// assigns value for price 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.42;
                    case Size.Medium: return 0.76;
                    case Size.Large: return 0.96;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// assigns value for calories 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 77;
                    case Size.Medium: return 89;
                    case Size.Large: return 100;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// returns blank list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();

        public override List<string> SpecialInstructions
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
