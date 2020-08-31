using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: SmokehouseSkeleton.cs 
 * Purpose: Class used to represent Smokehouse Skeleton and its properties 
 */

namespace BleakwindBuffet.Data.Entree
{
    public class SmokehouseSkeleton
    {
        /// <summary>
        /// gets price 
        /// </summary>
        public double Price => 5.62;
        /// <summary>
        /// gets calories 
        /// </summary>
        public uint Calories => 602;
        /// <summary>
        /// returns sausageLink and adds "hold sausage" to list if false 
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else specialInstructions.Remove("Hold sausage");
                sausageLink = value;
            }
        }
        /// <summary>
        /// returns hashBrowns and adds "hold hash browns" to list if false 
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold hash browns");
                else specialInstructions.Remove("Hold hash browns");
                hashBrowns = value;
            }
        }
        /// <summary>
        /// returns pancake and adds "hold pancake" to list if false 
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pancakes");
                else specialInstructions.Remove("Hold pancakes");
                pancake = value;
            }
        }
        /// <summary>
        /// returns egg and adds "hold eggs" to list if false 
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else specialInstructions.Remove("Hold eggs");
                egg = value;
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
        /// returns "Smokehouse Skeleton" 
        /// </summary>
        /// <returns>string "Smokehouse Skeleton"</returns>
        public override string ToString()
        {
            return "Smokhouse Skeleton"; 
        }
    }
}
