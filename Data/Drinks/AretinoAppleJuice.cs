using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: AretinoAppleJuice.cs 
 * Purpose: Class used to represent Aretino Apple Juice and its properties 
 */

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice
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
                if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
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
                if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
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
        /// returns Aretino Apple Juice with size 
        /// </summary>
        /// <returns>string "{Size} Aretino Apple Juice"</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice"; 
        }
    }
}
