using NUnit.Framework;
using ProductsLib;
using System.Collections.Generic;

namespace ProductLigTest
{
    [TestFixture]
    public class TestingFoodClass
    {
        public static object[] TestCasesSumFood =  
        {
            new object[] 
            { 
                new Food("Food", 7.0M, 10, 7, "Батон"),
                new Food("Food", 9.0M, 12, 10, "Батон"),
                new Food("Food", 8.0M, 11, 17, "Батон")
            },
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                new Food("Food", 7.3M, 18, 8, "Батон"),
                new Food("Food", 9.9M, 16.5f, 22, "Батон")
            },
            new object[]
            {
                new Food("Food", 11.8M, 20, 12, "Батон"),
                new Food("Food", 9.4M, 17, 10, "Батон"),
                new Food("Food", 10.6M, 18.5f, 22, "Батон")
            }
        };  // Набор условий для тестирования 
        public static object[] TestCasesSubFood =
        {
            new object[]
            {
                new Food("Food", 7.0M, 10, 7, "Батон"),
                5,
                new Food("Food", 7.0M, 10, 2, "Батон")
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 15, "Батон"),
                10,
                new Food("Food", 7.0M, 10, 5, "Батон")
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "Батон"),
                1,
                new Food("Food", 7.0M, 10, 2, "Батон")
            },
        }; // Набор условий для тестирования
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                1.03M
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "Батон"),
                2.57M
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                1.6M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                14.38M
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "Батон"),
                7.7M
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                11.2M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                1438
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "Батон"),
                770
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                1120
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                14.38
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "Батон"),
                7.70
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                11.20
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToSportGoods =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                new SportGoods("SportGoods", 12.5M, 15, 14, "Батон")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "Батон"),
                new SportGoods("SportGoods", 15.1M, 21, 12, "Батон")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                new SportGoods("SportGoods", 10.0M, 12, 7, "Батон")
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToClothes =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                new Clothes("Clothes", 12.5M, 15, 14, "Батон")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "Батон"),
                new Clothes("Clothes", 15.1M, 21, 12, "Батон")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                new Clothes("Clothes", 10.0M, 12, 7, "Батон")
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToShoes =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                new Shoes("Shoes", 12.5M, 15, 14, "Батон")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "Батон"),
                new Shoes("Shoes", 15.1M, 21, 12, "Батон")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                new Shoes("Shoes", 10.0M, 12, 7, "Батон")
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToBuildingMaterials =
        {
             new object[]
            {
                new Food("Food", 12.5M, 15, 14, "Батон"),
                new BuildingMaterials("BuildingMaterials", 12.5M, 15, 14, "Батон")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "Батон"),
                new BuildingMaterials("BuildingMaterials", 15.1M, 21, 12, "Батон")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "Батон"),
                new BuildingMaterials("BuildingMaterials", 10.0M, 12, 7, "Батон")
            }
        };  // Набор условий для тестирования

        [Test, TestCaseSource("TestCasesSumFood")]
        public void TestSumFood(Food food1, Food food2, Food expectedFood)  // Тестирование суммы Food
        {
            Assert.AreEqual(expectedFood, food1 + food2);
        }

        [Test, TestCaseSource("TestCasesSubFood")]
        public void TestSubFood(Food food1, int num, Food expectedFood)  // Тестирование разности Food
        {
            Assert.AreEqual(expectedFood, food1 - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestFoodUnitPrice(Food food, decimal expectedUnitPrice)  // Тестирование метода UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, food.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestFoodTotalPrice(Food food, decimal expectedTotalPrice)  // Тестирование метода TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, food.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestFoodConvertToInt(Food food, int expectedInt)  // Тестирование приведения к типу int
        {
            Assert.AreEqual(expectedInt, (int)food);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestFoodConvertToDouble(Food food, double expectedDouble)  // Тестирование приведения к типу double
        {
            Assert.AreEqual(expectedDouble, (double)food);
        }

        [Test, TestCaseSource("TestCasesConvertToSportGoods")]
        public void TestFoodConvertToSportGoods(Food food, SportGoods expectedSportGoods)  // Тестирование приведеня к типу SportGoods
        {
            Assert.AreEqual(expectedSportGoods, (SportGoods)food);
        }

        [Test, TestCaseSource("TestCasesConvertToClothes")]
        public void TestFoodConvertToClothes(Food food, Clothes expectedClothes)  // Тестирование приведения к типу Clothes
        {
            Assert.AreEqual(expectedClothes, (Clothes)food);
        }

        [Test, TestCaseSource("TestCasesConvertToShoes")]
        public void TestFoodConvertToShoes(Food food, Shoes expectedShoes)  // Тестирование приведения к типу Shoes
        {
            Assert.AreEqual(expectedShoes, (Shoes)food);
        }

        [Test, TestCaseSource("TestCasesConvertToBuildingMaterials")]
        public void TestFoodConvertToBuildingMaterials(Food food, BuildingMaterials expectedBuildingMaterials)  // Тестирование приведения к типу BuildingMaterials
        {
            Assert.AreEqual(expectedBuildingMaterials, (BuildingMaterials)food);
        }







    }
}