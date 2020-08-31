using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: BriarheartBurger.cs 
 * Purpose: Class used to represent Briarheart Burger and its properties 
 */

namespace BleakwindBuffet.Data.Entree
{
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets burger price 
        /// </summary>
        public double Price => 6.32; 
        /// <summary>
        /// get calories of burger 
        /// </summary>
        public uint Calories => 732; 

        /// <summary>
        /// returns ketchup or adds "Hold ketchup" to list if false 
        /// </summary>
        private bool ketchup = true; 
        public bool Ketchup
        {
            get
            {
                return ketchup; 
            }

            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup"); 
                ketchup = value; 
            }
        }
        /// <summary>
        /// returns bun or adds "Hold bun" to list if false 
        /// </summary>
        private bool bun = true; 
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else specialInstructions.Remove("Hold bun");
                bun = value;
            }
        }
        /// <summary>
        /// returns mustard and adds "Hold mustard" if false 
        /// </summary>
        private bool mustard = true;
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else specialInstructions.Remove("Hold mustard");
                mustard = value;
            }
        } 
        /// <summary>
        /// returns pickle and adds "hold pickle" to list if false 
        /// </summary>
        private bool pickle = true;  
        public bool Pickle
        {
            get
            {
                return pickle; 
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else specialInstructions.Remove("Hold pickle");
                pickle = value; 
            }
        }
        /// <summary>
        /// returns cheese and adds "hold cheese" to list if false 
        /// </summary>
        private bool cheese = true; 
        public bool Cheese
        {
            get
            {
                return cheese; 
            }
            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else specialInstructions.Remove("Hold cheese");
                cheese = value; 
            }
        } 
        /// <summary>
        /// returns copy of list of special instructions 
        /// </summary>
        private List<string> specialInstructions = new List<string>(); 
        public List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions); 
        } 
        /// <summary>
        /// displays "Briarheart Burger" 
        /// </summary>
        /// <returns>string "Briarheart Burger"</returns>
        public override string ToString()
        {
            return "Briarheart Burger"; 
        }
    }
}
