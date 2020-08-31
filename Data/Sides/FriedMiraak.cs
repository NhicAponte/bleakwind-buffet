using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak and its properties 
 */

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
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
        /// gets price base on size 
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.78;
                if (size == Size.Medium) return 2.01;
                if (size == Size.Large) return 2.88;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// gets calories based on size 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 151;
                if (size == Size.Medium) return 236;
                if (size == Size.Large) return 306;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// gets a blank list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Fried Miraak with size 
        /// </summary>
        /// <returns>string "{Size} Fried Miraak"</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
