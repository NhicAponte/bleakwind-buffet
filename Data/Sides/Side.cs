using BleakwindBuffet.Data.Enums; 
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// size of drink 
        /// </summary>
        public virtual Size Size { get; set; }
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
    }
}
