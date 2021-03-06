﻿/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Smokehouse Skeleton test class 
    /// </summary>
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(s);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(s);
        }

        [Fact]
        public void ChangingSausageLinkNotifiesSausageLinkProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Sausage Link", () =>
            {
                s.SausageLink = true;
            });
            Assert.PropertyChanged(s, "Sausage Link", () =>
            {
                s.SausageLink = false;
            });
        }
        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = true;
            });
            Assert.PropertyChanged(s, "Egg", () =>
            {
                s.Egg = false;
            });
        }
        [Fact]
        public void ChangingHashbrownsNotifiesHashbrownsProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Hashbrowns", () =>
            {
                s.HashBrowns = true;
            });
            Assert.PropertyChanged(s, "Hashbrowns", () =>
            {
                s.HashBrowns = false;
            });
        }
        [Fact]
        public void ChangingPancakesNotifiesPancakesProperty()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.PropertyChanged(s, "Pancakes", () =>
            {
                s.Pancake = true;
            });
            Assert.PropertyChanged(s, "Pancakes", () =>
            {
                s.Pancake = false;
            });
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(s);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.SausageLink); 
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.True(s.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.SausageLink = false;
            Assert.False(s.SausageLink);
            s.SausageLink = true; 
            Assert.True(s.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Egg = false;
            Assert.False(s.Egg);
            s.Egg = true;
            Assert.True(s.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.HashBrowns = false;
            Assert.False(s.HashBrowns);
            s.HashBrowns = true;
            Assert.True(s.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            s.Pancake = false;
            Assert.False(s.Pancake);
            s.Pancake = true;
            Assert.True(s.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal(5.62, s.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal((uint)602, s.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton(); 
            s.SausageLink = includeSausage;
            s.Egg = includeEgg;
            s.HashBrowns = includeHashbrowns;
            s.Pancake = includePancake; 
            if (!includeSausage) Assert.Contains("Hold sausage", s.SpecialInstructions);
            else if (!includeEgg) Assert.Contains("Hold egg", s.SpecialInstructions);
            else if (!includeHashbrowns) Assert.Contains("Hold hashbrowns", s.SpecialInstructions);
            else if (!includePancake) Assert.Contains("Hold pancake", s.SpecialInstructions); 
            else Assert.Empty(s.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", s.ToString()); 
        }
    }
}