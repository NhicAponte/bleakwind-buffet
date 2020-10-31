using BleakwindBuffet.Data.Enums; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name => ToString();

        /// <summary>
        /// size of side 
        /// </summary>
        private Size size = Size.Small;
        public virtual Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                OnPropertyChanged("Size");
                OnPropertyChanged("Price");
                OnPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// price of side 
        /// </summary>
        /// <value> 
        /// In US dollars 
        /// </value> 
        public abstract double Price { get; }
        /// <summary>
        /// calories in side 
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special instructions to prepare side 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
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
