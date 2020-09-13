/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides; 

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// This is the Dragonborn Waffle Fries test class 
    /// </summary>
    public class DragonbornWaffleFriesTests
    {
        [Fact] 
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dr); 
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dr.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            dr.Size = Size.Large;
            Assert.Equal(Size.Large, dr.Size); 
            dr.Size = Size.Medium; 
            Assert.Equal(Size.Medium, dr.Size); 
            dr.Size = Size.Small;
            Assert.Equal(Size.Small, dr.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            Assert.Empty(dr.SpecialInstructions); 
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            dr.Size = size;
            Assert.Equal(price, dr.Price); 
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            dr.Size = size;
            Assert.Equal(calories, dr.Calories);  
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dr = new DragonbornWaffleFries();
            dr.Size = size;
            Assert.Equal(name, dr.ToString()); 
        }
    }
}