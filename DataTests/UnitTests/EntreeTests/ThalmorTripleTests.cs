/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel; 


namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Thalmor Triple test class 
    /// </summary>
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(t);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(t);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(t);
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = true;
            });
            Assert.PropertyChanged(t, "Bun", () =>
            {
                t.Bun = false;
            });
        }
        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = true;
            });
            Assert.PropertyChanged(t, "Cheese", () =>
            {
                t.Cheese = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = true;
            });
            Assert.PropertyChanged(t, "Pickle", () =>
            {
                t.Pickle = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = true;
            });
            Assert.PropertyChanged(t, "Mustard", () =>
            {
                t.Mustard = false;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = true;
            });
            Assert.PropertyChanged(t, "Ketchup", () =>
            {
                t.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = true;
            });
            Assert.PropertyChanged(t, "Egg", () =>
            {
                t.Egg = false;
            });
        }
        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = true;
            });
            Assert.PropertyChanged(t, "Bacon", () =>
            {
                t.Bacon = false;
            });
        }
        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Mayo", () =>
            {
                t.Mayo = true;
            });
            Assert.PropertyChanged(t, "Mayo", () =>
            {
                t.Mayo = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = true;
            });
            Assert.PropertyChanged(t, "Lettuce", () =>
            {
                t.Lettuce = false;
            });
        }
        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = true;
            });
            Assert.PropertyChanged(t, "Tomato", () =>
            {
                t.Tomato = false;
            });
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bun); 
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();

            Assert.True(t.Tomato);

        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();

            Assert.True(t.Lettuce);

        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple t = new ThalmorTriple(); 
            Assert.True(t.Mayo);

        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.True(t.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bun = false;
            Assert.False(t.Bun);
            t.Bun = true;
            Assert.True(t.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Ketchup = false;
            Assert.False(t.Ketchup);
            t.Ketchup = true;
            Assert.True(t.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mustard = false;
            Assert.False(t.Mustard);
            t.Mustard = true;
            Assert.True(t.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Pickle = false;
            Assert.False(t.Pickle);
            t.Pickle = true;
            Assert.True(t.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Cheese = false;
            Assert.False(t.Cheese);
            t.Cheese = true;
            Assert.True(t.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Tomato = false;
            Assert.False(t.Tomato);
            t.Tomato = true;
            Assert.True(t.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Lettuce = false;
            Assert.False(t.Lettuce);
            t.Lettuce = true;
            Assert.True(t.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Mayo = false;
            Assert.False(t.Mayo);
            t.Mayo = true;
            Assert.True(t.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Bacon = false;
            Assert.False(t.Bacon);
            t.Bacon = true;
            Assert.True(t.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple t = new ThalmorTriple();
            t.Egg = false;
            Assert.False(t.Egg);
            t.Egg = true;
            Assert.True(t.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal(8.32, t.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal((uint)943, t.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple t = new ThalmorTriple(); 
            t.Bun = includeBun;
            t.Ketchup = includeKetchup;
            t.Mustard = includeMustard;
            t.Pickle = includePickle;
            t.Cheese = includeCheese;
            t.Tomato = includeTomato;
            t.Lettuce = includeLettuce;
            t.Bacon = includeBacon;
            t.Egg = includeEgg;
            t.Mayo = includeMayo; 
            if (!includeBun) Assert.Contains("Hold bun", t.SpecialInstructions);
            else if (!includeKetchup) Assert.Contains("Hold ketchup", t.SpecialInstructions);
            else if (!includeMustard) Assert.Contains("Hold mustard", t.SpecialInstructions);
            else if (!includePickle) Assert.Contains("Hold pickle", t.SpecialInstructions);
            else if (!includeCheese) Assert.Contains("Hold cheese", t.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", t.SpecialInstructions);
            else if (!includeLettuce) Assert.Contains("Hold lettuce", t.SpecialInstructions);
            else if (!includeMayo) Assert.Contains("Hold mayo", t.SpecialInstructions);
            else if (!includeBacon) Assert.Contains("Hold bacon", t.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold egg", t.SpecialInstructions);
            else Assert.Empty(t.SpecialInstructions); 
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple t = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", t.ToString()); 
        }
    }
}