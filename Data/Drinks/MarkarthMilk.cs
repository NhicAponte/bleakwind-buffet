using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: MarkarthMilk.cs 
 * Purpose: Class used to represent Markarth Milk and its properties 
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// gets and sets the size of the drink 
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
        /// gets the price based on the size of the drink 
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.05;
                if (size == Size.Medium) return 1.11;
                if (size == Size.Large) return 1.22;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// gets the calories based on the size of the drink 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 56;
                if (size == Size.Medium) return 72;
                if (size == Size.Large) return 93; 
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// gets and set the value of ice; adds "add ice" if true  
        /// </summary> 
        private bool ice = false;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value;
            }
        }
        /// <summary>
        /// gets copy of stored list of special instructions 
        /// </summary> 
        private List<string> specialInstructions = new List<string>(); 
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Markarth Milk with size 
        /// </summary>
        /// <returns>string "{Size} Markarth Milk"</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        } 
    }
}
