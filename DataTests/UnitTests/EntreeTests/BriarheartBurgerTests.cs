﻿/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Briarheart Burger test class 
    /// </summary>
    public class BriarheartBurgerTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            var b = new BriarheartBurger();
            Assert.IsAssignableFrom<IOrderItem>(b);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(b); 
        }
        [Fact] 
        public void ShouldBeAnEntree()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.IsAssignableFrom<Entree>(b); 
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = true;
            });
            Assert.PropertyChanged(b, "Bun", () =>
            {
                b.Bun = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = true;
            });
            Assert.PropertyChanged(b, "Cheese", () =>
            {
                b.Cheese = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = true;
            });
            Assert.PropertyChanged(b, "Pickle", () =>
            {
                b.Pickle = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = true;
            });
            Assert.PropertyChanged(b, "Mustard", () =>
            {
                b.Mustard = false;
            });
        }
        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = true;
            });
            Assert.PropertyChanged(b, "Ketchup", () =>
            {
                b.Ketchup = false;
            });
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Bun); 
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = false;
            Assert.False(b.Bun); 
            b.Bun = true; 
            Assert.True(b.Bun); 

        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Ketchup = false;
            Assert.False(b.Ketchup);
            b.Ketchup = true;
            Assert.True(b.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Mustard = false;
            Assert.False(b.Mustard);
            b.Mustard = true;
            Assert.True(b.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Pickle = false;
            Assert.False(b.Pickle);
            b.Pickle = true;
            Assert.True(b.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Cheese = false;
            Assert.False(b.Cheese);
            b.Cheese = true;
            Assert.True(b.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal(6.32, b.Price); 
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal((uint)743, b.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger b = new BriarheartBurger();
            b.Bun = includeBun;
            b.Ketchup = includeKetchup;
            b.Mustard = includeMustard;
            b.Pickle = includePickle;
            b.Cheese = includeCheese;
            if (!includeBun) Assert.Contains("Hold bun", b.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", b.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", b.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", b.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", b.SpecialInstructions);
            else Assert.Empty(b.SpecialInstructions); 
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.ToString()); 
        }
    }
}