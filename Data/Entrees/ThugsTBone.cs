/* Author: Nhicolas Aponte 
 * Class Name: ThugsTBone.cs 
 * Purpose: Class used to represent thugs T-Bone and its properties 
 */
using System;
using System.Collections.Generic;
using System.Text;


namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree, IOrderItem 
    {
        /// <summary>
        /// gets price 
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// gets calories 
        /// </summary>
        public override uint Calories => 982;
        /// <summary>
        /// gets copy of stored list of special instructions 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public override List<string> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// returns "Thugs T-Bone" 
        /// </summary>
        /// <returns>string "Thugs T-Bone"</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

    }
}
