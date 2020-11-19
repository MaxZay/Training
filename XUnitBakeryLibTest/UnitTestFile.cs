using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BakeryLib;

namespace XUnitBakeryLibTest
{
    public class UnitTestFile
    {
        [Fact]
        public void TestFileReadFromFile()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Вода", 0.2M, 0, 100),
                new Ingredient("Мука", 0.3M, 360, 350),
                new Ingredient("Масло", 1M, 884, 50)
            };
            Production production = new Production("Батон", ingredients, 20);
            List<Ingredient> ingredients1 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),
                new Ingredient("Вода", 0.2M, 0, 100),
                new Ingredient("Дрожжи", 0.5M, 325, 25),
                new Ingredient("Масло", 1M, 884, 50)
            };
            Production production1 = new Production("Хлеб", ingredients1, 15);
            List<Production> products = new List<Production> { production, production1 };
            Bakery expectedBakery = new Bakery(products.ToArray());

            // Act
            Bakery bakery = File.ReadFromFile(@"C:\Users\maxim\Documents\EPAM\Решения\EpamTask1\BakeryInfo.txt");


            // Assert
            Assert.Equal(expectedBakery, bakery);
        }
    }
}
