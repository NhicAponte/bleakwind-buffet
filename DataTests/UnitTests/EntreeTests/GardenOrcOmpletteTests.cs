﻿/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    /// <summary>
    /// This is the Garden Orc Omelette test class 
    /// </summary>
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldImplementCorrectInterfaces()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(g);
            Assert.IsAssignableFrom<INotifyPropertyChanged>(g);
        }
        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(g);
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = true;
            });
            Assert.PropertyChanged(g, "Tomato", () =>
            {
                g.Tomato = false;
            });
        }
        [Fact]
        public void ChangingCheddarNotifiesCheddarProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = true;
            });
            Assert.PropertyChanged(g, "Cheddar", () =>
            {
                g.Cheddar = false;
            });
        }
        [Fact]
        public void ChangingMushroomsNotifiesMushroomsProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = true;
            });
            Assert.PropertyChanged(g, "Mushrooms", () =>
            {
                g.Mushrooms = false;
            });
        }
        [Fact]
        public void ChangingBroccoliNotifiesBroccoliProperty()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = true;
            });
            Assert.PropertyChanged(g, "Broccoli", () =>
            {
                g.Broccoli = false;
            });
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Broccoli); 
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.True(g.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = false;
            Assert.False(g.Broccoli);
            g.Broccoli = true;
            Assert.True(g.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Mushrooms = false;
            Assert.False(g.Mushrooms);
            g.Mushrooms = true;
            Assert.True(g.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Tomato = false;
            Assert.False(g.Tomato);
            g.Tomato = true;
            Assert.True(g.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Cheddar = false;
            Assert.False(g.Cheddar);
            g.Cheddar = true;
            Assert.True(g.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal(4.57, g.Price); 
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal((uint)404, g.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            g.Broccoli = includeBroccoli;
            g.Mushrooms = includeMushrooms;
            g.Tomato = includeTomato;
            g.Cheddar = includeCheddar;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", g.SpecialInstructions);
            else if (!includeMushrooms) Assert.Contains("Hold mushrooms", g.SpecialInstructions);
            else if (!includeTomato) Assert.Contains("Hold tomato", g.SpecialInstructions);
            else if (!includeCheddar) Assert.Contains("Hold cheddar", g.SpecialInstructions); 
            else Assert.Empty(g.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette g = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", g.ToString()); 
        }
    }
}