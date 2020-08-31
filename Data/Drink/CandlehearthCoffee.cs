using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: CandlehearthCoffee.cs 
 * Purpose: Class used to represent Candlehearth Coffee and its properties 
 */

namespace BleakwindBuffet.Data.Drink
{
    public class CandlehearthCoffee
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
                if (size == Size.Small) return 0.75;
                if (size == Size.Medium) return 1.25;
                if (size == Size.Large) return 1.75; 
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
                if (size == Size.Small) return 7;
                if (size == Size.Medium) return 10;
                if (size == Size.Large) return 20;
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
                if (!value) specialInstructions.Add("Add Ice");
                else specialInstructions.Remove("Add Ice");
                ice = value;
            }
        }
        /// <summary>
        /// gets and sets the value of roomForCream; adds "add cream" if true  
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                if (!value) specialInstructions.Add("Add cream");
                else specialInstructions.Remove("Add cream");
                roomForCream = value;
            }
        }
        /// <summary>
        /// gets and sets the value of decaf; adds "add cream" if true  
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                //if (!value) specialInstructions.Add("Decaf");
                //else specialInstructions.Remove("Decaf");
                decaf = value;
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
        /// returns Candlehearth Coffee with size and whether or not it's decaf 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!decaf)
            {
                return $"{Size} Decaf Candlehearth Coffee"; 

            }
            else
            {
                return $"{Size} Candlehearth Coffee"; 
            }
        }
    }
}
