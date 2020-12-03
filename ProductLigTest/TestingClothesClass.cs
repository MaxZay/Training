using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProductsLib;

namespace ProductLigTest
{
    [TestFixture]
    class TestingClothesClass
    {
        public static object[] TestCasesSumClothes =
        {
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 32, 250, "Куртка"),
                new Clothes("Clothes", 5000.0M, 2, 120, "Куртка"),
                new Clothes("Clothes", 7500.0M, 17, 370, "Куртка")
            },
            new object[]
            {
                new Clothes("Clothes", 6000.0M, 27, 301, "Куртка"),
                new Clothes("Clothes", 1000.0M, 15, 92, "Куртка"),
                new Clothes("Clothes", 3500.0M, 21, 393, "Куртка")
            },
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 1500, "Куртка"),
                new Clothes("Clothes", 1350.0M, 22, 174, "Куртка"),
                new Clothes("Clothes", 7300.0M, 42, 1674, "Куртка")
            }
        };  // Набор условий для тестирования 
        public static object[] TestCasesSubClothes =
        {
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 32, 250, "Куртка"),
                200,
                new Clothes("Clothes", 10000.0M, 32, 50, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 32, 120, "Куртка"),
                10,
                new Clothes("Clothes", 10000.0M, 32, 110, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 32, 300, "Куртка"),
                40,
                new Clothes("Clothes", 10000.0M, 32, 260, "Куртка"),
            },
        }; // Набор условий для тестирования
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 1500, "Куртка"),
                14.31M
            },
            new object[]
            {
                new Clothes("Clothes", 1350.0M, 22, 174, "Куртка"),
                9.47M
            },
            new object[]
            {
                new Clothes("Clothes", 7300.0M, 42, 100, "Куртка"),
                103.66M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                21465.0M
            },
            new object[]
            {
                new Clothes("Clothes", 1350.0M, 22, 174, "Куртка"),
                1647.0M
            },
            new object[]
            {
                new Clothes("Clothes", 7300.0M, 42, 100, "Куртка"),
                10366.0M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                2146500
            },
            new object[]
            {
                new Clothes("Clothes", 1350.0M, 22, 174, "Куртка"),
                164700
            },
            new object[]
            {
                new Clothes("Clothes", 7300.0M, 42, 100, "Куртка"),
                1036600
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                21465.0
            },
            new object[]
            {
                new Clothes("Clothes", 1350.0M, 22, 174, "Куртка"),
                1647.0
            },
            new object[]
            {
                new Clothes("Clothes", 7300.0M, 42, 100, "Куртка"),
                10366.0
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToFood =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                new Food("Food", 13250.0M, 62, 400, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 22, 500, "Куртка"),
                new Food("Food", 10000.0M, 22, 500, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 7777.0M, 7, 777, "Куртка"),
                new Food("Food", 7777.0M, 7, 777, "Куртка"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToSportGoods =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                new SportGoods("SportGoods", 13250.0M, 62, 400, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 22, 500, "Куртка"),
                new SportGoods("SportGoods", 10000.0M, 22, 500, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 7777.0M, 7, 777, "Куртка"),
                new SportGoods("SportGoods", 7777.0M, 7, 777, "Куртка"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToShoes =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                new Shoes("Shoes", 13250.0M, 62, 400, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 22, 500, "Куртка"),
                new Shoes("Shoes", 10000.0M, 22, 500, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 7777.0M, 7, 777, "Куртка"),
                new Shoes("Shoes", 7777.0M, 7, 777, "Куртка"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToBuildingMaterials =
        {
            new object[]
            {
                new Clothes("Clothes", 13250.0M, 62, 400, "Куртка"),
                new BuildingMaterials("BuildingMaterials", 13250.0M, 62, 400, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 10000.0M, 22, 500, "Куртка"),
                new BuildingMaterials("BuildingMaterials", 10000.0M, 22, 500, "Куртка"),
            },
            new object[]
            {
                new Clothes("Clothes", 7777.0M, 7, 777, "Куртка"),
                new BuildingMaterials("BuildingMaterials", 7777.0M, 7, 777, "Куртка"),
            }
        };  // Набор условий для тестирования

        [Test, TestCaseSource("TestCasesSumClothes")]
        public void TestSumClothes(Clothes clothes1, Clothes clothes2, Clothes expectedClothes)  // Тестирование суммы Food
        {
            Assert.AreEqual(expectedClothes, clothes1 + clothes2);
        }

        [Test, TestCaseSource("TestCasesSubClothes")]
        public void TestSubClothes(Clothes clothes1, int num, Clothes expectedClothes)  // Тестирование разности Food
        {
            Assert.AreEqual(expectedClothes, clothes1 - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestFoodUnitPrice(Clothes clothes, decimal expectedUnitPrice)  // Тестирование метода UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, clothes.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestFoodTotalPrice(Clothes clothes, decimal expectedTotalPrice)  // Тестирование метода TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, clothes.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestFoodConvertToInt(Clothes clothes, int expectedInt)  // Тестирование приведения к типу int
        {
            Assert.AreEqual(expectedInt, (int)clothes);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestFoodConvertToDouble(Clothes clothes, double expectedDouble)  // Тестирование приведения к типу double
        {
            Assert.AreEqual(expectedDouble, (double)clothes);
        }

        [Test, TestCaseSource("TestCasesConvertToFood")]
        public void TestFoodConvertToFood(Clothes clothes, Food expectedFood)  // Тестирование приведеня к типу Food
        {
            Assert.AreEqual(expectedFood, (Food)clothes);
        }

        [Test, TestCaseSource("TestCasesConvertToSportGoods")]
        public void TestFoodConvertToClothes(Clothes clothes, SportGoods expectedSportGoods)  // Тестирование приведения к типу Clothes
        {
            Assert.AreEqual(expectedSportGoods, (SportGoods)clothes);
        }

        [Test, TestCaseSource("TestCasesConvertToShoes")]
        public void TestFoodConvertToShoes(Clothes clothes, Shoes expectedShoes)  // Тестирование приведения к типу Shoes
        {
            Assert.AreEqual(expectedShoes, (Shoes)clothes);
        }

        [Test, TestCaseSource("TestCasesConvertToBuildingMaterials")]
        public void TestFoodConvertToBuildingMaterials(Clothes clothes, BuildingMaterials expectedBuildingMaterials)  // Тестирование приведения к типу BuildingMaterials
        {
            Assert.AreEqual(expectedBuildingMaterials, (BuildingMaterials)clothes);
        }
    }
}
