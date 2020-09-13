using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing common properties of drinks 
    /// </summary>
    public abstract class Drink
    {
        //virtual can't be overriden but that's okay for size: can use a private backing variable  
        //abstract can be overriden so we use that since each 
        //drink has it's own price and calories 
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
