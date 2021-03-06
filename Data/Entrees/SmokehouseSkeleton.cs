﻿/* Author: Nhicolas Aponte 
 * Class Name: SmokehouseSkeleton.cs 
 * Purpose: Class used to represent Smokehouse Skeleton and its properties 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// event handler from INotifyPropertyChanged interface 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// entree description
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
        /// <summary>
        /// gets price 
        /// </summary>
        public override double Price => 5.62;
        /// <summary>
        /// gets calories 
        /// </summary>
        public override uint Calories => 602;
        /// <summary>
        /// returns sausageLink and adds "hold sausage" to list if false 
        /// </summary>
        private bool sausageLink = true;
        public bool SausageLink
        {
            get
            {
                return sausageLink;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else specialInstructions.Remove("Hold sausage");
                sausageLink = value;
                OnPropertyChanged("Sausage Link"); 
            }
        }
        /// <summary>
        /// returns hashBrowns and adds "hold hash browns" to list if false 
        /// </summary>
        private bool hashBrowns = true;
        public bool HashBrowns
        {
            get
            {
                return hashBrowns;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold hash browns");
                else specialInstructions.Remove("Hold hash browns");
                hashBrowns = value;
                OnPropertyChanged("Hashbrowns");
            }
        }
        /// <summary>
        /// returns pancake and adds "hold pancake" to list if false 
        /// </summary>
        private bool pancake = true;
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold pancakes");
                else specialInstructions.Remove("Hold pancakes");
                pancake = value;
                OnPropertyChanged("Pancakes");
            }
        }
        /// <summary>
        /// returns egg and adds "hold eggs" to list if false 
        /// </summary>
        private bool egg = true;
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else specialInstructions.Remove("Hold eggs");
                egg = value;
                OnPropertyChanged("Egg"); 
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
        /// returns "Smokehouse Skeleton" 
        /// </summary>
        /// <returns>string "Smokehouse Skeleton"</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton"; 
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
