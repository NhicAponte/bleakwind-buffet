using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: WarriorWater.cs 
 * Purpose: Class used to represent Warrior Water and its properties 
 */

namespace BleakwindBuffet.Data.Drink
{
    public class WarriorWater
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
                if (size == Size.Small) return 0.0;
                if (size == Size.Medium) return 0.0;
                if (size == Size.Large) return 0.0;
                else return 0.0; 
            }
        }
        /// <summary>
        /// gets the calories based on the size of the drink 
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small) return 0;
                if (size == Size.Medium) return 0;
                if (size == Size.Large) return 0;
                else return 0;
            }
        }
        /// <summary>
        /// gets and set the value of ice; adds "hold ice" if false  
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
            }
        } 
        /// <summary>
        /// gets and sets value of lemon; adds "add lemon" to list if true 
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                if (!value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                lemon = value;
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
        /// returns Warrior Water with size 
        /// </summary>
        /// <returns>string "{Size} Warrior Water"</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
