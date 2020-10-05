/* Author: Nhicolas Aponte 
 * Class Name: DoubleDraugr.cs 
 * Purpose: Class used to represent Double Draugr and its properties 
 */

using System;
using System.ComponentModel; 
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr : Entree, INotifyPropertyChanged 
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets burger price 
        /// </summary>
        public override double Price => 7.32; 
        /// <summary>
        /// gets burger calories 
        /// </summary>
        public override uint Calories => 843;
        /// <summary>
        /// returns bun and adds "hold bun" to list if false 
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
            }
        }
        /// <summary>
        /// returns ketchup and adds "hold ketchup" to list if false 
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
            }
        }
        /// <summary>
        /// returns mustard and adds "hold mustard" to list if false 
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
                OnPropertyChanged("Tomato");
            }
        }
        /// <summary>
        /// returns lettuce and adds "hold lettuce" to list if false 
        /// </summary>
        private bool lettuce = true; 
        public bool Lettuce 
        {
            get
            {
                return lettuce; 
            }
            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else specialInstructions.Remove("Hold lettuce");
                lettuce = value;
                OnPropertyChanged("Lettuce");
            }
        }
        /// <summary>
        /// returns mayo and adds "hold mayo" to list if false 
        /// </summary>
        private bool mayo = true; 
        public bool Mayo 
        {
            get
            {
                return mayo; 
            }
            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else specialInstructions.Remove("Hold mayo");
                mayo = value;
                OnPropertyChanged("Mayo");
            }
        }
        /// <summary>
        /// gets copy of stored list of special instructions 
        /// </summary>
        private List<string> specialInstructions = new List<string>(); 
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions); 
        } 
        /// <summary>
        /// returns "Double Draugr" 
        /// </summary>
        /// <returns>string "Double Draugr"</returns>
        public override string ToString()
        {
            return "Double Draugr"; 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="property"></param>
        public void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
