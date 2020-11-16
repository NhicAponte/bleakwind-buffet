/*
 * Author: Nhicolas Aponte 
 * Class: IOrderItem.cs 
 * Purpose: Test the IOrderItem.cs interface in the Data library
 */
using BleakwindBuffet.Data.Enums; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// price of item 
        /// </summary>\
        /// <value> 
        /// In US dollars 
        /// </value> 
        double Price { get; }
        /// <summary>
        /// calories in item 
        /// </summary>
        uint Calories { get; } 
        /// <summary>
        /// special instructions for item 
        /// </summary>
        List<string> SpecialInstructions { get; }
        //Action<object, PropertyChangedEventArgs> PropertyChanged { get; set; }
        string Name { get; }

        string Category { get; }
        string Description { get; }
    }
}
