using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: MadOtarGrits.cs 
 * Purpose: Class used to represent Mad Otar Grits and its properties 
 */

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        /// <summary>
        /// gets and sets size 
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
        /// gets price based on size 
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small) return 1.22;
                if (size == Size.Medium) return 1.58;
                if (size == Size.Large) return 1.93;
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
                if (size == Size.Small) return 105;
                if (size == Size.Medium) return 142;
                if (size == Size.Large) return 179;
                else throw new NotImplementedException();
            }
        }
        /// <summary>
        /// gets blank list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Mad Otar Grits and size 
        /// </summary>
        /// <returns>string "{Size} Mad Otar Grits" </returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
