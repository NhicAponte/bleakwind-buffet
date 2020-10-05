/* Author: Nhicolas Aponte 
 * Class Name: VokunSalad.cs 
 * Purpose: Class used to represent Vokun Salad and its properties 
 */

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class VokunSalad : Side, INotifyPropertyChanged 
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small; 
        /// <summary>
        /// gets and sets value of size 
        /// </summary>
        /// <summary>
        /// gets price based on size  
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.93;
                    case Size.Medium: return 1.28;
                    case Size.Large: return 1.82;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// gets calories based on size 
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 41;
                    case Size.Medium: return 52;
                    case Size.Large: return 73;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// returns an empty list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Vokun Salad and size 
        /// </summary>
        /// <returns>string "{Size} Vokun Salad"</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad"; 
        }
    }
}
