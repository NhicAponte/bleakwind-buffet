using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks; 
using BleakwindBuffet.Data.Entrees; 
using BleakwindBuffet.Data.Sides; 

namespace BleakwindBuffet.Data
{
    public class Combo: IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public uint Calories
        {
            get
            {
                return entree.Calories + side.Calories + drink.Calories; 
            }
        }

        public double Price
        {
            get
            {
                return entree.Price + side.Price + drink.Price - 1; 
            }
        }

        private Drink drink; 
        public Drink Drink
        {
            get
            {
                return drink; 
            }
            set
            {
                drink = value; 
            }
        }
        /// <summary>
        /// gets or sets value of entree 
        /// </summary>
        private Entree entree; 
        public Entree Entree
        {
            get
            {
                return entree; 
            }
            set
            {
                entree = value; 
            }
        }
        /// <summary>
        /// gets or sets side 
        /// </summary>
        private Side side; 
        public Side Side
        {
            get
            {
                return side; 
            }
            set
            {
                side = value; 
            }
        }
        /// <summary>
        /// returns special instructions for combo 
        /// </summary>
        private List<string> specialInstructions = new List<string>(); 
        public List<string> SpecialInstructions
        {
            get
            {
                specialInstructions.Add(Entree.Name);
                specialInstructions.AddRange(Entree.SpecialInstructions);
                specialInstructions.Add(Side.Name); 
                specialInstructions.AddRange(Side.SpecialInstructions); 
                specialInstructions.Add(Drink.Name); 
                specialInstructions.AddRange(Drink.SpecialInstructions);
                return specialInstructions; 
            }
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
