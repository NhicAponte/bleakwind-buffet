/* Author: Nhicolas Aponte 
 * Class Name: SailorSoda.cs 
 * Purpose: Class used to represent Sailor Soda and its properties 
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets and sets the size of the drink 
        /// </summary> 
        private Size size = Size.Small;
        /// <summary>
        /// drink description 
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }

        /// <summary>
        /// gets the price based on the size of the drink 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
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
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// gets and set the value of ice; adds "hold ice" if false 
        /// </summary>
        private bool ice = true;
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
                OnPropertyChanged("Ice");
            }
        }
        /// <summary>
        /// gets and sets the value of flavor 
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry; 
        public SodaFlavor Flavor
        {
            get
            {
                return flavor; 
            }
            set
            {
                flavor = value;
                OnPropertyChanged("Flavor"); 
                OnPropertyChanged("SpecialInstructions"); 
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
        /// returns Sailor Soda with size and flavor 
        /// </summary>
        /// <returns>string "{Size} {Flavor} Sailor Soda"</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
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
