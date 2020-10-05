/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;
using System.ComponentModel;  

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Double Draugr test class 
    /// </summary>
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<IOrderItem>(d);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(d);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(d);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Bun", () =>
            {
                d.Bun = true;
            });
            Assert.PropertyChanged(d, "Bun", () =>
            {
                d.Bun = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Cheese", () =>
            {
                d.Cheese = true;
            });
            Assert.PropertyChanged(d, "Cheese", () =>
            {
                d.Cheese = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Pickle", () =>
            {
                d.Pickle = true;
            });
            Assert.PropertyChanged(d, "Pickle", () =>
            {
                d.Pickle = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Mustard", () =>
            {
                d.Mustard = true;
            });
            Assert.PropertyChanged(d, "Mustard", () =>
            {
                d.Mustard = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Ketchup", () =>
            {
                d.Ketchup = true;
            });
            Assert.PropertyChanged(d, "Ketchup", () =>
            {
                d.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Mayo", () =>
            {
                d.Mayo = true;
            });
            Assert.PropertyChanged(d, "Mayo", () =>
            {
                d.Mayo = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Lettuce", () =>
            {
                d.Lettuce = true;
            });
            Assert.PropertyChanged(d, "Lettuce", () =>
            {
                d.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.PropertyChanged(d, "Tomato", () =>
            {
                d.Tomato = true;
            });
            Assert.PropertyChanged(d, "Tomato", () =>
            {
                d.Tomato = false;
            });
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Bun); 
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = false;
            Assert.False(d.Bun);
            d.Bun = true;
            Assert.True(d.Bun); 
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Ketchup = false;
            Assert.False(d.Ketchup);
            d.Ketchup = true;
            Assert.True(d.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mustard = false;
            Assert.False(d.Mustard);
            d.Mustard = true;
            Assert.True(d.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Pickle = false;
            Assert.False(d.Pickle);
            d.Pickle = true;
            Assert.True(d.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Cheese = false;
            Assert.False(d.Cheese);
            d.Cheese = true;
            Assert.True(d.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Tomato = false;
            Assert.False(d.Tomato);
            d.Tomato = true;
            Assert.True(d.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Lettuce = false;
            Assert.False(d.Lettuce);
            d.Lettuce = true;
            Assert.True(d.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Mayo = false;
            Assert.False(d.Mayo);
            d.Mayo = true;
            Assert.True(d.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal(7.32, d.Price); 
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal((uint)843, d.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr d = new DoubleDraugr();
            d.Bun = includeBun;
            d.Ketchup = includeKetchup;
            d.Mustard = includeMustard;
            d.Pickle = includePickle;
            d.Cheese = includeCheese; 
            d.Tomato = includeTomato; 
            d.Lettuce = includeLettuce; 
            d.Mayo = includeMayo; 
            if (!includeBun) Assert.Contains("Hold bun", d.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", d.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", d.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", d.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", d.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", d.SpecialInstructions);
            else if (!includeLettuce) Assert.Contains("Hold lettuce", d.SpecialInstructions);
            else if (!includeMayo) Assert.Contains("Hold mayo", d.SpecialInstructions);
            else Assert.Empty(d.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr d = new DoubleDraugr();
            Assert.Equal("Double Draugr", d.ToString()); 
        }
    }
}