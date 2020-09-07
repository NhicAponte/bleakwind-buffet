using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: GardenOrcOmelette.cs 
 * Purpose: Class used to represent Garden Orc Omelette and its properties 
 */

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// gets price 
        /// </summary>
        public double Price => 4.57;
        /// <summary>
        /// gets calories 
        /// </summary>
        public uint Calories => 404;
        /// <summary>
        /// returns broccoli and adds "hold broccoli" to list if false 
        /// </summary>
        private bool broccoli = true;
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else specialInstructions.Remove("Hold broccoli");
                broccoli = value;
            }
        }
        /// <summary>
        /// returns mushroom and adds "hold mushroom" to list if false 
        /// </summary>
        private bool mushrooms = true;
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else specialInstructions.Remove("Hold mushrooms");
                mushrooms = value;
            }
        }
        /// <summary>
        /// returns tomato and adds "hold tomato" to list if false 
        /// </summary>
        private bool tomato = true;
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
            }
        }
        /// <summary>
        /// returns cheddar and adds "hold cheddar" to list if false 
        /// </summary>
        private bool cheddar = true;
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else specialInstructions.Remove("Hold cheddar");
                cheddar = value;
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
        /// returns "Garden Orc Omelette" 
        /// </summary>
        /// <returns>string "Garden Orc Omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
