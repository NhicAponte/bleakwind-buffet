﻿/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;


namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    /// <summary>
    /// This is the Mad Otar Grits test class 
    /// </summary>
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeMenuItem()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<IOrderItem>(mo);
        }
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(mo);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Equal(Size.Small, mo.Size); 
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = Size.Large;
            Assert.Equal(Size.Large, mo.Size);
            mo.Size = Size.Medium;
            Assert.Equal(Size.Medium, mo.Size);
            mo.Size = Size.Small;
            Assert.Equal(Size.Small, mo.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits mo = new MadOtarGrits();
            Assert.Empty(mo.SpecialInstructions); 
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(price, mo.Price); 
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(calories, mo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits mo = new MadOtarGrits();
            mo.Size = size;
            Assert.Equal(name, mo.ToString()); 
        }
    }
}