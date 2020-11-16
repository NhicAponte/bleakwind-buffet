using BleakwindBuffet.Data.Enums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks 
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged 
    {
        //virtual can't be overriden but that's okay for size: can use a private backing variable  
        //abstract can be overriden so we use that since each 
        //drink has it's own price and calories 
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name => ToString();

        public abstract string Description { get; }

        public string Category
        {
            get
            {
                return "Drink";
            }
        }

        private Size size = Size.Small;
        /// <summary>
        /// size of drink 
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                OnPropertyChanged("Size");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
                OnPropertyChanged("Name");
            }
        }
        /// <summary>
        /// price of drink 
        /// </summary>
        /// <value> 
        /// In US dollars 
        /// </value> 
        public abstract double Price { get; } 
        /// <summary>
        /// calories in drink 
        /// </summary>
        public abstract uint Calories { get; } 
        /// <summary>
        /// Special instructions to prepare drink 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
        
        /// <summary>
        /// Method to incoke PropertyChanged even handler 
        /// </summary>
        /// <param name="property"></param>
        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        } 
    }
}
