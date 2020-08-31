using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: VokunSalad.cs 
 * Purpose: Class used to represent Vokun Salad and its properties 
 */

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad
    {
        private Size size = Size.Small; 
        /// <summary>
        /// gets and sets value of size 
        /// </summary>
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
        /// gets price based on size  
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 0.39;
                if (size == Size.Medium) return 1.28;
                if (size == Size.Large) return 1.82;
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
                if (size == Size.Small) return 41;
                if (size == Size.Medium) return 52;
                if (size == Size.Large) return 73;
                else throw new NotImplementedException(); 
            }
        }
        /// <summary>
        /// returns an empty list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Vokun Salad and size 
        /// </summary>
        /// <returns>string "{Size} Vokun Salad"</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad"; 
        }
    }
}
