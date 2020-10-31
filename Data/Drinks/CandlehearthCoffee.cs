/* Author: Nhicolas Aponte 
 * Class Name: CandlehearthCoffee.cs 
 * Purpose: Class used to represent Candlehearth Coffee and its properties 
 */


using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee : Drink, INotifyPropertyChanged 
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets and sets the size of the drink 
        /// </summary> 
        private Size size = Size.Small; 
        /*public Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }*/ 
        /// <summary>
        /// gets the price based on the size of the drink 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: 
                        return 0.75;
                    case Size.Medium: 
                        return 1.25;
                    case Size.Large: 
                        return 1.75;
                    default: throw new NotImplementedException("Invalid Size");
            }
               
            }
        }
        /// <summary>
        /// gets the calories based on the size of the drink 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: 
                        return 7;
                    case Size.Medium: 
                        return 10;
                    case Size.Large: 
                        return 20;
                    default: throw new NotImplementedException("Invalid Size");
                }
                
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
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
                ice = value;
                OnPropertyChanged("Ice"); 
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
                if (value) specialInstructions.Add("Leave room for cream");
                else specialInstructions.Remove("Leave room for cream");
                roomForCream = value;
                OnPropertyChanged("RoomForCream"); 
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
                OnPropertyChanged("Decaf"); 
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
        /// returns Candlehearth Coffee with size and whether or not it's decaf 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (decaf)
            {
                return $"{Size} Decaf Candlehearth Coffee"; 

            }
            else
            {
                return $"{Size} Candlehearth Coffee"; 
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
