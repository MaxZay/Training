using System;
using Xunit;
using BakeryLib;
using System.Collections.Generic;

namespace XUnitBakeryLibTest
{
    public class UnitTestProduction
    {
        [Fact]
        public void TestProductionCalorificValue()  // Тестирование метода GetCalorificValue()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("Вода", 0.2M, 0, 100),
                    new Ingredient("Мука", 0.3M, 360, 350),
                    new Ingredient("Масло", 1M, 884, 50)
            };
            Production production = new Production("Батон", ingredients, 20);
            float expectedCalorificValue = 1702;

            // Act
            float realCalorificValue = production.GetCalorificValue();

            // Assert
            Assert.Equal(expectedCalorificValue, realCalorificValue);
        }

        [Fact]
        public void TestProductPrice()  // Тестирование метода GetPrice()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("Вода", 0.2M, 0, 100),
                    new Ingredient("Мука", 0.3M, 360, 350),
                    new Ingredient("Масло", 1.0M, 884, 50)
            };
            Production production = new Production("Батон", ingredients, 20);
            decimal expectedPrice = 2.1M;

            // Act
            decimal realPrice = production.GetPrice();

            // Assert
            Assert.Equal(expectedPrice, realPrice);
        }
    
        [Fact]
        public void TestProductWeight() // Тестирование свойста Weight
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                    new Ingredient("Вода", 0.2M, 0, 100),
                    new Ingredient("Мука", 0.3M, 360, 350),
                    new Ingredient("Масло", 1.0M, 884, 50)
            };
            Production production = new Production("Батон", ingredients, 20);
            float expectedWeight = 500;

            // Act
            float realWeight = production.Weight;

            // Assert
            Assert.Equal(expectedWeight, realWeight);
        }
    }
}
