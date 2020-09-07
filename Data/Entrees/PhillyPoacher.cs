using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: PhillyPoacher.cs 
 * Purpose: Class used to represent PhillyPoacher and its properties 
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// gets price 
        /// </summary>
        public double Price => 7.23;
        /// <summary>
        /// gets calories 
        /// </summary>
        public uint Calories => 784;
        /// <summary>
        /// returns sirloin and adds "hold sirloin" to list if false 
        /// </summary>
        private bool sirloin = true;
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else specialInstructions.Remove("Hold sirloin");
                sirloin = value;
            }
        }
        /// <summary>
        /// returns onion and adds "hold onion" to list if false 
        /// </summary>
        private bool onion = true;
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold onions");
                else specialInstructions.Remove("Hold onions");
                onion = value;
            }
        }
        /// <summary>
        /// returns roll and adds "hold roll" to list if false 
        /// </summary>
        private bool roll = true;
        public bool Roll 
        {
            get
            {
                return roll;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else specialInstructions.Remove("Hold roll");
                roll = value;
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
        /// returns "Philly Poacher" 
        /// </summary>
        /// <returns>string "Philly Poacher"</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }

    }
}
