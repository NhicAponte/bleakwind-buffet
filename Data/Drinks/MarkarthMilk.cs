/* Author: Nhicolas Aponte 
 * Class Name: MarkarthMilk.cs 
 * Purpose: Class used to represent Markarth Milk and its properties 
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;



namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged; 

        /// <summary>
        /// gets the price based on the size of the drink 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.05;
                    case Size.Medium: return 1.11;
                    case Size.Large: return 1.22;
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
                    case Size.Small: return 56;
                    case Size.Medium: return 72;
                    case Size.Large: return 93;
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
        /// gets copy of stored list of special instructions 
        /// </summary> 
        private List<string> specialInstructions = new List<string>(); 
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Markarth Milk with size 
        /// </summary>
        /// <returns>string "{Size} Markarth Milk"</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
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
