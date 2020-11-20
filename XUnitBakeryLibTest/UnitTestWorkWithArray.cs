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
        public void TestWorkWithFileOrderByCalorificValue()  // Тестирование метода  OrderByCalorificValue()
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

        [Fact]
        public void TestWorkWithFileOrderByPrice()  // ТЕстирование метода OrderByPrice()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Вода", 0.2M, 0, 100), // 0.2
                new Ingredient("Мука", 0.3M, 360, 350), // 1.05
                new Ingredient("Масло", 1M, 884, 50) // 0.5   2.1
            };
            Production production = new Production("Батон", ingredients, 20);
            List<Ingredient> ingredients1 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350), // 1.05
                new Ingredient("Вода", 0.2M, 0, 100),  // 0.2
                new Ingredient("Дрожжи", 0.5M, 325, 25),  // 0.125
                new Ingredient("Масло", 1M, 884, 50)  // 0.5  2.16
            };
            Production production1 = new Production("Хлеб", ingredients1, 15);
            List<Ingredient> ingredients2 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 150),  // 0.45
                new Ingredient("Вода", 0.2M, 0, 200),  // 0.4
                new Ingredient("Дрожжи", 0.5M, 325, 50),  // 0.25
                new Ingredient("Масло", 1M, 884, 100)  // 1  2.63
            };
            Production production2 = new Production("Хлеб Минский", ingredients2, 25);
            List<Ingredient> ingredients3 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),  // 1.05
                new Ingredient("Вода", 0.2M, 0, 100),  // 0.2
                new Ingredient("Масло", 1M, 884, 50),  // 1
                new Ingredient("Сахар", 0.7M, 325, 125),  // 0.875
                new Ingredient("Сгущенка", 0.2M, 416, 100)  // 0.2  3.88
            };
            Production production3 = new Production("Плюшка со сгущенкой", ingredients3, 15);
            List<Production> expectedProducts = new List<Production> { production, production1, production2, production3 };
            List<Production> testProducts = new List<Production> { production, production1, production2, production3 };
            Bakery expectedBakery = new Bakery(expectedProducts.ToArray());
            Bakery bakery = new Bakery(testProducts.ToArray());

            // Act
            bakery.Products = WorkWithArray.OrderByPrice(bakery);

            // Assert
            Assert.Equal(expectedBakery, bakery);
        }

        [Fact]
        public void TestFindProductsEqualsByPriceAndCalorificValue()  // Тестирование мотеда FindProductsEqualsByPriceAndCalorificValue()
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
            List<Ingredient> ingredients2 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 150), 
                new Ingredient("Вода", 0.2M, 0, 200),  
                new Ingredient("Дрожжи", 0.5M, 325, 50), 
                new Ingredient("Масло", 1M, 884, 100)  
            };
            Production production2 = new Production("Хлеб Минский", ingredients2, 25);
            List<Ingredient> ingredients3 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),  
                new Ingredient("Вода", 0.2M, 0, 100), 
                new Ingredient("Масло", 1M, 884, 50),  
                new Ingredient("Сахар", 0.7M, 325, 125),  
                new Ingredient("Сгущенка", 0.2M, 416, 100)  
            };
            Production production3 = new Production("Плюшка со сгущенкой", ingredients3, 15);
            List<Production> expectedProducts = new List<Production> { production2 };
            List<Production> testProducts = new List<Production> { production, production1, production2, production3 };
            Bakery bakery = new Bakery(testProducts.ToArray());

            // Act
            Production[] productionArr = WorkWithArray.FindProductsEqualsByPriceAndCalorificValue(bakery, 2.62M, 1586f);

            // Assert
            Assert.Equal(expectedProducts.ToArray(), productionArr);
        }
        
        [Fact]
        public void TestFindProductsCountMoreThanNumber() // Тестирование метода FindProductsCountMoreThanNumber()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Вода", 0.2M, 0, 100), // 0.2
                new Ingredient("Мука", 0.3M, 360, 350), // 1.05
                new Ingredient("Масло", 1M, 884, 50) // 0.5   2.1
            };
            Production production = new Production("Батон", ingredients, 20);
            List<Ingredient> ingredients1 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350), // 1.05
                new Ingredient("Вода", 0.2M, 0, 100),  // 0.2
                new Ingredient("Дрожжи", 0.5M, 325, 25),  // 0.125
                new Ingredient("Масло", 1M, 884, 50)  // 0.5  2.16
            };
            Production production1 = new Production("Хлеб", ingredients1, 15);
            List<Ingredient> ingredients2 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 150),  // 0.45
                new Ingredient("Вода", 0.2M, 0, 200),  // 0.4
                new Ingredient("Дрожжи", 0.5M, 325, 50),  // 0.25
                new Ingredient("Масло", 1M, 884, 100)  // 1  2.63
            };
            Production production2 = new Production("Хлеб Минский", ingredients2, 25);
            List<Ingredient> ingredients3 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),  // 1.05
                new Ingredient("Вода", 0.2M, 0, 100),  // 0.2
                new Ingredient("Масло", 1M, 884, 50),  // 1
                new Ingredient("Сахар", 0.7M, 325, 125),  // 0.875
                new Ingredient("Сгущенка", 0.2M, 416, 100)  // 0.2  3.88
            };
            Production production3 = new Production("Плюшка со сгущенкой", ingredients3, 15);
            List<Production> expectProducts = new List<Production>() { production1, production2, production3};
            List<Production> testProducts = new List<Production>() { production, production1, production2, production3 };
            Bakery actualBakery = new Bakery(testProducts.ToArray());
            Bakery expectedBakery = new Bakery(expectProducts.ToArray());

            // Act
            actualBakery.Products = WorkWithArray.FindProductsCountMoreThanNumber(actualBakery, 3);

            // Assert
            Assert.Equal(expectedBakery, actualBakery);
        }

        [Fact]
        public void TestFindProductsByVolume()  // Тестирование метода FindProductsByVolume()
        {
            // Arrange
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient("Вода", 0.2M, 0, 100), 
                new Ingredient("Мука", 0.3M, 360, 350), 
                new Ingredient("Масло", 1M, 884, 50)  //500  70%
            };
            Production production = new Production("Батон", ingredients, 20);
            List<Ingredient> ingredients1 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350), 
                new Ingredient("Вода", 0.2M, 0, 100),  
                new Ingredient("Дрожжи", 0.5M, 325, 25), 
                new Ingredient("Масло", 1M, 884, 50)  //525  66.67%
            };
            Production production1 = new Production("Хлеб", ingredients1, 15);
            List<Ingredient> ingredients2 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 150),  
                new Ingredient("Вода", 0.2M, 0, 200),  
                new Ingredient("Дрожжи", 0.5M, 325, 50),  
                new Ingredient("Масло", 1M, 884, 100)  //500    30%
            };
            Production production2 = new Production("Хлеб Минский", ingredients2, 25);
            List<Ingredient> ingredients3 = new List<Ingredient>()
            {
                new Ingredient("Мука", 0.3M, 360, 350),  
                new Ingredient("Вода", 0.2M, 0, 100),  
                new Ingredient("Масло", 1M, 884, 50),  
                new Ingredient("Сахар", 0.7M, 325, 125), 
                new Ingredient("Сгущенка", 0.2M, 416, 100)  //725  48%
            };
            Production production3 = new Production("Плюшка со сгущенкой", ingredients3, 15);
            List<Production> testProducts = new List<Production>() { production, production1, production2, production3 };
            List<Production> expectedProducts = new List<Production>() { production, production1};
            Bakery actualBakery = new Bakery(testProducts.ToArray());
            Bakery expectedBakery = new Bakery(expectedProducts.ToArray());

            // Act
            actualBakery.Products = WorkWithArray.FindProductsByVolume(actualBakery, "Мука", 50);

            // Arrange
            Assert.Equal(expectedBakery, actualBakery);
        }
    }
}
