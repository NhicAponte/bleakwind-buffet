﻿ /* Author: Nhicolas Aponte 
 * Class Name: BriarheartBurger.cs 
 * Purpose: Class used to represent Briarheart Burger and its properties 
 */ 
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text; 

namespace BleakwindBuffet.Data.Entrees
{
    public class BriarheartBurger : Entree, INotifyPropertyChanged 
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// entree description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }

        /// <summary>
        /// Gets burger price 
        /// </summary>
        public override double Price => 6.32; 
        /// <summary>
        /// get calories of burger 
        /// </summary>
        public override uint Calories => 743; 

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
                OnPropertyChanged("Ketchup");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Bun");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Mustard");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Pickle");
                OnPropertyChanged("SpecialInstructions");
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
                OnPropertyChanged("Cheese");
                OnPropertyChanged("SpecialInstructions");

            }
        } 
        /// <summary>
        /// returns copy of list of special instructions 
        /// </summary>
        private List<string> specialInstructions = new List<string>(); 
        public override List<string> SpecialInstructions
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
        /// <summary>
        /// Method to incoke PropertyChanged even handler 
        /// </summary>
        /// <param name="property"></param>
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); 
        } 
    }
}
