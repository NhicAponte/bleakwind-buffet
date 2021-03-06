﻿/* Author: Nhicolas Aponte 
 * Class Name: AretinoAppleJuice.cs 
 * Purpose: Class used to represent Aretino Apple Juice and its properties 
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel; 
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink, INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// drink description 
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fresh squeezed apple juice.";
            }
        }

        /// <summary>
        /// gets and sets the size of the drink 
        /// </summary> 
        /*private Size size = Size.Small; 
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                if (size == Size.Medium) { OnPropertyChanged("Medium"); }
                if (size == Size.Large) { OnPropertyChanged("Large"); }
                if (size == Size.Small) { OnPropertyChanged("Small"); }
            }
        }*/
        /// <summary>
        /// gets the price based on the size of the drink 
        /// </summary>
        public override double Price
        {
            get
            {
                /*if (size == Size.Small) return 0.62;
                if (size == Size.Medium) return 0.87;
                if (size == Size.Large) return 1.01;
                else throw new NotImplementedException();*/
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
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
                /*if (size == Size.Small) return 44;
                if (size == Size.Medium) return 88;
                if (size == Size.Large) return 132;
                else throw new NotImplementedException();*/
                switch (Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
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
        /// returns Aretino Apple Juice with size 
        /// </summary>
        /// <returns>string "{Size} Aretino Apple Juice"</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice"; 
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
