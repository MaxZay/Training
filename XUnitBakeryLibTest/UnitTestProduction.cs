using System;
using Xunit;
using BakeryLib;
using System.Collections.Generic;

namespace XUnitBakeryLibTest
{
    public class UnitTestProduction
    {
        [Fact]
        public void TestProductionCalorificValue()  // ������������ ������ GetCalorificValue()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("����", 0.2M, 0, 100),
                    new Ingredient("����", 0.3M, 360, 350),
                    new Ingredient("�����", 1M, 884, 50)
            };
            Production production = new Production("�����", ingredients, 20);
            float expectedCalorificValue = 1702;

            // Act
            float realCalorificValue = production.GetCalorificValue();

            // Assert
            Assert.Equal(expectedCalorificValue, realCalorificValue);
        }

        [Fact]
        public void TestProductPrice()  // ������������ ������ GetPrice()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("����", 0.2M, 0, 100),
                    new Ingredient("����", 0.3M, 360, 350),
                    new Ingredient("�����", 1.0M, 884, 50)
            };
            Production production = new Production("�����", ingredients, 20);
            decimal expectedPrice = 2.1M;

            // Act
            decimal realPrice = production.GetPrice();

            // Assert
            Assert.Equal(expectedPrice, realPrice);
        }
    
        [Fact]
        public void TestProductWeight() // ������������ ������� Weight
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("����", 0.2M, 0, 100),
                    new Ingredient("����", 0.3M, 360, 350),
                    new Ingredient("�����", 1.0M, 884, 50)
            };
            Production production = new Production("�����", ingredients, 20);
            float expectedWeight = 500;

            // Act
            float realWeight = production.Weight;

            // Assert
            Assert.Equal(expectedWeight, realWeight);
        }
    }
}
