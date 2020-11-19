using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BakeryLib;

namespace XUnitBakeryLibTest
{
    public class UnitTestIngredient
    {
        [Fact]
        public void TestIngredientTestPrice() // Тестирование свойства RealPrice
        {
            // Arrange
            Ingredient ingredient = new Ingredient("Масло", 1M, 884, 50);
            decimal expectedPrice = 0.5M;
            // Act
            decimal realPrice = ingredient.RealPrice;

            // Assert
            Assert.Equal(expectedPrice, realPrice);
        }

        [Fact]
        public void TestIngredientTestCalorificValue()  // Тестирование свойства RealCalorificValue 
        {
            // Arrange
            Ingredient ingredient = new Ingredient("Масло", 1M, 884, 50);
            float expextedCalorificValue = 442;
            // Act
            float realCalorificValue = ingredient.RealCalorificValue;

            // Assert
            Assert.Equal(expextedCalorificValue, realCalorificValue);
        }
    }
}
