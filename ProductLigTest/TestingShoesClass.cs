using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;
using NUnit.Framework;

namespace ProductLigTest
{
    [TestFixture]
    public class TestingShoesClass
    {
        public static object[] TestCasesSumShoes =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                new Shoes("Shoes", 5000.0M, 2, 120, "Кросовки"),
                new Shoes("Shoes", 7500.0M, 17, 370, "Кросовки")
            },
            new object[]
            {
                new Shoes("Shoes", 1000.0M, 26, 20, "Туфли"),
                new Shoes("Shoes", 4000.0M, 18, 100, "Туфли"),
                new Shoes("Shoes", 2500.0M, 22, 120, "Туфли")
            },
            new object[]
            {
                new Shoes("Shoes", 20000.0M, 15, 300, "Кросовки"),
                new Shoes("Shoes", 6000.0M, 11, 40, "Кросовки"),
                new Shoes("Shoes", 13000.0M, 13, 340, "Кросовки")
            }
        };  // Набор условий для тестирования 
        public static object[] TestCasesSubShoes =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                150,
                new Shoes("Shoes", 10000.0M, 32, 100, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                10,
                new Shoes("Shoes", 10000.0M, 32, 240, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                200,
                new Shoes("Shoes", 10000.0M, 32, 50, "Кросовки"),
            },
        }; // Набор условий для тестирования
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new Shoes("Shoes", 20000.0M, 15, 300, "Кросовки"),
                76.77M
            },
            new object[]
            {
                new Shoes("Shoes", 4000.0M, 18, 100, "Туфли"),
                47.20M
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                52.80M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new Shoes("Shoes", 20000.0M, 15, 300, "Кросовки"),
                23000.0M
            },
            new object[]
            {
                new Shoes("Shoes", 4000.0M, 18, 100, "Туфли"),
                4720.0M
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                13200.0M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new Shoes("Shoes", 20000.0M, 15, 300, "Кросовки"),
                2300000
            },
            new object[]
            {
                new Shoes("Shoes", 4000.0M, 18, 100, "Туфли"),
                472000
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                1320000
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new Shoes("Shoes", 20000.0M, 15, 300, "Кросовки"),
                23000.0
            },
            new object[]
            {
                new Shoes("Shoes", 4000.0M, 18, 100, "Туфли"),
                4720.0
            },
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                13200.0
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToFood =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                new Food("Food", 10000.0M, 32, 250, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 777777.7M, 32, 7777, "Кросовки"),
                new Food("Food", 777777.7M, 32, 7777, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 70000.0M, 21, 7777, "Кросовки"),
                new Food("Food", 70000.0M, 21, 7777, "Кросовки"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToSportGoods =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                new SportGoods("SportGoods", 10000.0M, 32, 250, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 777777.7M, 32, 7777, "Кросовки"),
                new SportGoods("SportGoods", 777777.7M, 32, 7777, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 70000.0M, 21, 7777, "Кросовки"),
                new SportGoods("SportGoods", 70000.0M, 21, 7777, "Кросовки"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToClothes =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                new Clothes("Clothes", 10000.0M, 32, 250, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 777777.7M, 32, 7777, "Кросовки"),
                new Clothes("Clothes", 777777.7M, 32, 7777, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 70000.0M, 21, 7777, "Кросовки"),
                new Clothes("Clothes", 70000.0M, 21, 7777, "Кросовки"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToBuildingMaterials =
        {
            new object[]
            {
                new Shoes("Shoes", 10000.0M, 32, 250, "Кросовки"),
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 777777.7M, 32, 7777, "Кросовки"),
                new BuildingMaterials("BuildingMaterials", 777777.7M, 32, 7777, "Кросовки"),
            },
            new object[]
            {
                new Shoes("Shoes", 70000.0M, 21, 7777, "Кросовки"),
                new BuildingMaterials("BuildingMaterials", 70000.0M, 21, 7777, "Кросовки"),
            }
        };  // Набор условий для тестирования

        [Test, TestCaseSource("TestCasesSumShoes")]
        public void TestSumClothes(Shoes shoes1, Shoes shoes2, Shoes expectedShoes)  // Тестирование суммы Food
        {
            Assert.AreEqual(expectedShoes, shoes1 + shoes2);
        }

        [Test, TestCaseSource("TestCasesSubShoes")]
        public void TestSubClothes(Shoes shoes, int num, Shoes expectedShoes)  // Тестирование разности Food
        {
            Assert.AreEqual(expectedShoes, shoes - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestFoodUnitPrice(Shoes shoes, decimal expectedUnitPrice)  // Тестирование метода UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, shoes.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestFoodTotalPrice(Shoes shoes, decimal expectedTotalPrice)  // Тестирование метода TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, shoes.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestFoodConvertToInt(Shoes shoes, int expectedInt)  // Тестирование приведения к типу int
        {
            Assert.AreEqual(expectedInt, (int)shoes);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestFoodConvertToDouble(Shoes shoes, double expectedDouble)  // Тестирование приведения к типу double
        {
            Assert.AreEqual(expectedDouble, (double)shoes);
        }

        [Test, TestCaseSource("TestCasesConvertToFood")]
        public void TestFoodConvertToFood(Shoes shoes, Food expectedFood)  // Тестирование приведеня к типу Food
        {
            Assert.AreEqual(expectedFood, (Food)shoes);
        }

        [Test, TestCaseSource("TestCasesConvertToSportGoods")]
        public void TestFoodConvertToSportGoods(Shoes shoes, SportGoods expectedSportGoods)  // Тестирование приведения к типу SportGoods
        {
            Assert.AreEqual(expectedSportGoods, (SportGoods)shoes);
        }

        [Test, TestCaseSource("TestCasesConvertToClothes")]
        public void TestFoodConvertToShoes(Shoes shoes, Clothes expectedClothes)  // Тестирование приведения к типу Clothes
        {
            Assert.AreEqual(expectedClothes, (Clothes)shoes);
        }

        [Test, TestCaseSource("TestCasesConvertToBuildingMaterials")]
        public void TestFoodConvertToBuildingMaterials(Shoes shoes, BuildingMaterials expectedBuildingMaterials)  // Тестирование приведения к типу BuildingMaterials
        {
            Assert.AreEqual(expectedBuildingMaterials, (BuildingMaterials)shoes);
        }
    }
}
