/* Author: Nhicolas Aponte 
 * Class Name: GardenOrcOmelette.cs 
 * Purpose: Class used to represent Garden Orc Omelette and its properties 
 */

using System;
using System.ComponentModel; 
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree, INotifyPropertyChanged 
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
                return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            }
        }
        /// <summary>
        /// gets price 
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// gets calories 
        /// </summary>
        public override uint Calories => 404;
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
                OnPropertyChanged("Broccoli");
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
                OnPropertyChanged("Mushrooms");
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
                OnPropertyChanged("Cheddar");
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
        /// returns "Garden Orc Omelette" 
        /// </summary>
        /// <returns>string "Garden Orc Omelette"</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
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
