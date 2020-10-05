/* Author: Nhicolas Aponte 
 * Class Name: MadOtarGrits.cs 
 * Purpose: Class used to represent Mad Otar Grits and its properties 
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side, INotifyPropertyChanged 
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets and sets size 
        /// </summary>
        private Size size = Size.Small; 
        /// <summary>
        /// gets price based on size 
        /// </summary>
        public override double Price
        {
            get
            {

                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
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
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException("Invalid Size");
                }
            }
        }
        /// <summary>
        /// gets blank list 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns Mad Otar Grits and size 
        /// </summary>
        /// <returns>string "{Size} Mad Otar Grits" </returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
