using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using ProductsLib;

namespace ProductLigTest
{
    [TestFixture]
    class TestingSportGoodsClass
    {
        public static object[] TestCasesSumSportGoods =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                new SportGoods("SportGoods", 9.0M, 12, 10, "Мяч"),
                new SportGoods("SportGoods", 8.0M, 11, 17, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 15, 14, "Мяч"),
                new SportGoods("SportGoods", 7.3M, 18, 8, "Мяч"),
                new SportGoods("SportGoods", 9.9M, 16.5f, 22, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 11.8M, 20, 12, "Мяч"),
                new SportGoods("SportGoods", 9.4M, 17, 10, "Мяч"),
                new SportGoods("SportGoods", 10.6M, 18.5f, 22, "Мяч")
            }
        };  // Набор условий для тестирования 
        public static object[] TestCasesSubSportGoods =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                5,
                new SportGoods("SportGoods", 7.0M, 10, 2, "Мяч"),
            },
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 12, "Мяч"),
                10,
                new SportGoods("SportGoods", 7.0M, 10, 2, "Мяч"),
            },
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                1,
                new SportGoods("SportGoods", 7.0M, 10, 6, "Мяч"),
            },
        }; // Набор условий для тестирования
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                1.10M
            },
            new object[]
            {
                new SportGoods("SportGoods", 35.0M, 23, 6, "Мяч"),
                7.18M
            },
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 17, 2, "Мяч"),
                7.31M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                7.70M
            },
            new object[]
            {
                new SportGoods("SportGoods", 35.0M, 23, 6, "Мяч"),
                43.05M
            },
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 17, 2, "Мяч"),
                14.62M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                770
            },
            new object[]
            {
                new SportGoods("SportGoods", 35.0M, 23, 6, "Мяч"),
                4305
            },
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 17, 2, "Мяч"),
                1462
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new SportGoods("SportGoods", 7.0M, 10, 7, "Мяч"),
                7.70
            },
            new object[]
            {
                new SportGoods("SportGoods", 35.0M, 23, 6, "Мяч"),
                43.05
            },
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 17, 2, "Мяч"),
                14.62
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToFood =
        {
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 15, 14, "Мяч"),
                new Food("Food", 12.5M, 15, 14, "Мяч"),
            },
            new object[]
            {   
                new SportGoods("SportGoods", 15.1M, 21, 12, "Мяч"),
                new Food("Food", 15.1M, 21, 12, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 10.0M, 12, 7, "Мяч"),
                new Food("Food", 10.0M, 12, 7, "Мяч"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToClothes =
        {
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 15, 14, "Мяч"),
                new Clothes("Clothes", 12.5M, 15, 14, "Мяч"),
            },
            new object[]
            {
                new SportGoods("SportGoods", 15.1M, 21, 12, "Мяч"),
                new Clothes("Clothes", 15.1M, 21, 12, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 10.0M, 12, 7, "Мяч"),
                new Clothes("Clothes", 10.0M, 12, 7, "Мяч"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToShoes =
        {
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 15, 14, "Мяч"),
                new Shoes("Shoes", 12.5M, 15, 14, "Мяч"),
            },
            new object[]
            {
                new SportGoods("SportGoods", 15.1M, 21, 12, "Мяч"),
                new Shoes("Shoes", 15.1M, 21, 12, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 10.0M, 12, 7, "Мяч"),
                new Shoes("Shoes", 10.0M, 12, 7, "Мяч"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToBuildingMaterials =
        {
            new object[]
            {
                new SportGoods("SportGoods", 12.5M, 15, 14, "Мяч"),
                new BuildingMaterials("BuildingMaterials", 12.5M, 15, 14, "Мяч"),
            },
            new object[]
            {
                new SportGoods("SportGoods", 15.1M, 21, 12, "Мяч"),
                new BuildingMaterials("BuildingMaterials", 15.1M, 21, 12, "Мяч")
            },
            new object[]
            {
                new SportGoods("SportGoods", 10.0M, 12, 7, "Мяч"),
                new BuildingMaterials("BuildingMaterials", 10.0M, 12, 7, "Мяч"),
            }
        };  // Набор условий для тестирования

        [Test, TestCaseSource("TestCasesSumSportGoods")]
        public void TestSumSportGoods(SportGoods sportGoods1, SportGoods sportGood2, SportGoods expectedSportGood)  // Тестирование суммы Food
        {
            Assert.AreEqual(expectedSportGood, sportGoods1 + sportGood2);
        }

        [Test, TestCaseSource("TestCasesSubSportGoods")]
        public void TestSubFood(SportGoods sportGoods1, int num, SportGoods expectedSportGood)  // Тестирование разности Food
        {
            Assert.AreEqual(expectedSportGood, sportGoods1 - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestFoodUnitPrice(SportGoods sportGoods, decimal expectedUnitPrice)  // Тестирование метода UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, sportGoods.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestFoodTotalPrice(SportGoods sportGoods, decimal expectedTotalPrice)  // Тестирование метода TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, sportGoods.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestFoodConvertToInt(SportGoods sportGoods, int expectedInt)  // Тестирование приведения к типу int
        {
            Assert.AreEqual(expectedInt, (int)sportGoods);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestFoodConvertToDouble(SportGoods sportGoods, double expectedDouble)  // Тестирование приведения к типу double
        {
            Assert.AreEqual(expectedDouble, (double)sportGoods);
        }

        [Test, TestCaseSource("TestCasesConvertToFood")]
        public void TestFoodConvertToFood(SportGoods sportGoods, Food expectedFood)  // Тестирование приведеня к типу SportGoods
        {
            Assert.AreEqual(expectedFood, (Food)sportGoods);
        }

        [Test, TestCaseSource("TestCasesConvertToClothes")]
        public void TestFoodConvertToClothes(SportGoods sportGoods,  Clothes expectedClothes)  // Тестирование приведения к типу Clothes
        {
            Assert.AreEqual(expectedClothes, (Clothes)sportGoods);
        }

        [Test, TestCaseSource("TestCasesConvertToShoes")]
        public void TestFoodConvertToShoes(SportGoods sportGoods, Shoes expectedShoes)  // Тестирование приведения к типу Shoes
        {
            Assert.AreEqual(expectedShoes, (Shoes)sportGoods);
        }

        [Test, TestCaseSource("TestCasesConvertToBuildingMaterials")]
        public void TestFoodConvertToBuildingMaterials(SportGoods sportGoods, BuildingMaterials expectedBuildingMaterials)  // Тестирование приведения к типу BuildingMaterials
        {
            Assert.AreEqual(expectedBuildingMaterials, (BuildingMaterials)sportGoods);
        }
    }
}
