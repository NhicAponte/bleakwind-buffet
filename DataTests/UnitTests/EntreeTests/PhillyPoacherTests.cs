﻿/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Philly Poacher test class 
    /// </summary>
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<IOrderItem>(p);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(p);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(p);
        }

        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Sirloin", () =>
            {
                p.Sirloin = true;
            });
            Assert.PropertyChanged(p, "Sirloin", () =>
            {
                p.Sirloin = false;
            });
        }
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Onion", () =>
            {
                p.Onion = true;
            });
            Assert.PropertyChanged(p, "Onion", () =>
            {
                p.Onion = false;
            });
        }
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.PropertyChanged(p, "Roll", () =>
            {
                p.Roll = true;
            });
            Assert.PropertyChanged(p, "Roll", () =>
            {
                p.Roll = false;
            });
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin); 
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Sirloin = false;
            Assert.False(p.Sirloin);
            p.Sirloin = true; 
            Assert.True(p.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Onion = false;
            Assert.False(p.Onion);
            p.Onion = true;
            Assert.True(p.Onion); 
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher p = new PhillyPoacher();
            p.Roll = false;
            Assert.False(p.Roll);
            p.Roll = true;
            Assert.True(p.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal(7.23, p.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal((uint)784, p.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher p = new PhillyPoacher(); 
            p.Sirloin = includeSirloin;
            p.Onion = includeOnion;
            p.Roll = includeRoll; 
            if (!includeSirloin) Assert.Contains("Hold sirloin", p.SpecialInstructions);
            else if (!includeOnion) Assert.Contains("Hold onion", p.SpecialInstructions);
            else if (!includeRoll) Assert.Contains("Hold roll", p.SpecialInstructions);
            else Assert.Empty(p.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher p = new PhillyPoacher();
            Assert.Equal("Philly Poacher", p.ToString()); 
        }
    }
}