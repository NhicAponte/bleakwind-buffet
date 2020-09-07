/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Thugs T-Bone test class 
    /// </summary>
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone h = new ThugsTBone();
            Assert.Equal(6.42, h.Price); 
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone h = new ThugsTBone();
            Assert.Equal((uint)982, h.Price);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone h = new ThugsTBone();
            Assert.Empty(h.SpecialInstructions); 
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone h = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", h.ToString()); 
        }
    }
}