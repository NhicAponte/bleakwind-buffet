
using System;
using System.Collections.Generic;
using System.Text;

/* Author: Nhicolas Aponte 
 * Class Name: ThigsTBone.cs 
 * Purpose: Class used to represent higs T-Bone and its properties 
 */

namespace Bleakwind.Data.Entrees
{
    public class ThugsTBone
    {
        /// <summary>
        /// gets price 
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// gets calories 
        /// </summary>
        public uint Calories => 982;
        /// <summary>
        /// gets copy of stored list of special instructions 
        /// </summary>
        private List<string> specialInstructions = new List<string>();
        public List<string> SpecialInstructions
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
