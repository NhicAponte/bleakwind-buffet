using BleakwindBuffet.Data.Enums; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of entrees 
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name => ToString();

        /// <summary>
        /// price of entree 
        /// </summary>\
        /// <value> 
        /// In US dollars 
        /// </value> 
        public abstract double Price { get; }
        /// <summary>
        /// calories in entree 
        /// </summary>
        public abstract uint Calories { get; } 
        /// <summary>
        /// Special instructions to prepare entree 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
