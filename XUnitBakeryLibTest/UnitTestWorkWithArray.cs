using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BakeryLib;

namespace XUnitBakeryLibTest
{
    public class UnitTestWorkWithArray
    {
        [Fact]
        public void TestWorkWithFileOrderByCalorificValue()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Вода", 0.2M, 0, 100), // 0
                new Ingredient("Мука", 0.3M, 360, 350), // 1260
                new Ingredient("Масло", 1M, 884, 50) // 442   1702
            };
            Production production = new Production("Батон", ingredients, 20);
            List<Ingredient> ingredients1 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350), // 1260
                new Ingredient("Вода", 0.2M, 0, 100),  // 0
                new Ingredient("Дрожжи", 0.5M, 325, 25),  // 81.25
                new Ingredient("Масло", 1M, 884, 50)  // 442  1783.25
            };
            Production production1 = new Production("Хлеб", ingredients1, 15);
            List<Ingredient> ingredients2 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 150),  // 540
                new Ingredient("Вода", 0.2M, 0, 200),  // 0
                new Ingredient("Дрожжи", 0.5M, 325, 50),  // 162.5
                new Ingredient("Масло", 1M, 884, 100)  // 884  1586.5
            };
            Production production2 = new Production("Хлеб Минский", ingredients2, 25);
            List<Ingredient> ingredients3 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),  // 1260
                new Ingredient("Вода", 0.2M, 0, 100),  // 0
                new Ingredient("Масло", 1M, 884, 50),  // 442
                new Ingredient("Сахар", 0.7M, 325, 125),  // 406.25
                new Ingredient("Сгущенка", 0.2M, 416, 100)  // 416 2524.25
            };
            Production production3 = new Production("Плюшка со сгущенкой", ingredients3, 15);
            List<Production> expectedProducts = new List<Production> { production2, production, production1, production3 };
            List<Production> testProducts = new List<Production> { production, production1, production2, production3 };
            Bakery expectedBakery = new Bakery(expectedProducts.ToArray());
            Bakery testBakery = new Bakery(testProducts.ToArray());

            // Act
            testBakery.Products = WorkWithArray.OrderByCalorificValue(testBakery);

            // Assert
            Assert.Equal(expectedBakery, testBakery);
            
        }
    }
}
