using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProductsLib;

namespace ProductLigTest
{
    [TestFixture]
    public class TestingBuildingMaterials
    {
        public static object[] TestCasesSumBuildingMaterials =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Гипсокартон"),
                new BuildingMaterials("BuildingMaterials", 5000.0M, 2, 120, "Гипсокартон"),
                new BuildingMaterials("BuildingMaterials", 7500.0M, 17, 370, "Гипсокартон")
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 1000.0M, 26, 20, "Бетон"),
                new BuildingMaterials("BuildingMaterials", 4000.0M, 18, 100, "Бетон"),
                new BuildingMaterials("BuildingMaterials", 2500.0M, 22, 120, "Бетон")
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 20000.0M, 15, 300, "Клей"),
                new BuildingMaterials("BuildingMaterials", 6000.0M, 11, 40, "Клей"),
                new BuildingMaterials("BuildingMaterials", 13000.0M, 13, 340, "Клей")
            }
        };  // Набор условий для тестирования 
        public static object[] TestCasesSubBuildingMaterials =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Гипсокартон"),
                150,
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 100, "Гипсокартон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Гипсокартон"),
                100,
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 150, "Гипсокартон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Гипсокартон"),
                200,
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 50, "Гипсокартон")
            },
        }; // Набор условий для тестирования
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 20000.0M, 15, 300, "Бетон"),
                76.67M
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 4000.0M, 18, 100, "Бетон"),
                47.20M
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                52.80M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 20000.0M, 15, 300, "Бетон"),
                23000.0M
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 4000.0M, 18, 100, "Бетон"),
                4720.0M
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                13200.0M
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 20000.0M, 15, 300, "Бетон"),
                2300000
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 4000.0M, 18, 100, "Бетон"),
                472000
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                1320000
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 20000.0M, 15, 300, "Бетон"),
                23000.0
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 4000.0M, 18, 100, "Бетон"),
                4720.0
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                13200.0
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToFood =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                new Food("Food", 10000.0M, 32, 250, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 777777.7M, 32, 7777, "Бетон"),
                new Food("Food", 777777.7M, 32, 7777, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 70000.0M, 21, 7777, "Бетон"),
                new Food("Food", 70000.0M, 21, 7777, "Бетон"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToSportGoods =
        {
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
                new SportGoods("SportGoods", 10000.0M, 32, 250, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 777777.7M, 32, 7777, "Бетон"),
                new SportGoods("SportGoods", 777777.7M, 32, 7777, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 70000.0M, 21, 7777, "Бетон"),
                new SportGoods("SportGoods", 70000.0M, 21, 7777, "Бетон"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToClothes =
        {
            new object[]
            {
               new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
               new Clothes("Clothes", 10000.0M, 32, 250, "Бетон"),
            },
            new object[]
            {
               new BuildingMaterials("BuildingMaterials", 777777.7M, 32, 7777, "Бетон"),
               new Clothes("Clothes", 777777.7M, 32, 7777, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 70000.0M, 21, 7777, "Бетон"),
                new Clothes("Clothes", 70000.0M, 21, 7777, "Бетон"),
            }
        };  // Набор условий для тестирования
        public static object[] TestCasesConvertToShoes =
        {
            new object[]
            {
               new BuildingMaterials("BuildingMaterials", 10000.0M, 32, 250, "Бетон"),
               new Shoes("Shoes", 10000.0M, 32, 250, "Бетон"),
            },
            new object[]
            {
               new BuildingMaterials("BuildingMaterials", 777777.7M, 32, 7777, "Бетон"),
               new Shoes("Shoes", 777777.7M, 32, 7777, "Бетон"),
            },
            new object[]
            {
                new BuildingMaterials("BuildingMaterials", 70000.0M, 21, 7777, "Бетон"),
                new Shoes("Shoes", 70000.0M, 21, 7777, "Бетон"),
            }
        };  // Набор условий для тестирования

        [Test, TestCaseSource("TestCasesSumBuildingMaterials")]
        public void TestSumBuildingMaterials(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2, BuildingMaterials expectedSBuildingMaterials)  // Тестирование суммы Food
        {
            Assert.AreEqual(expectedSBuildingMaterials, buildingMaterials1 + buildingMaterials2);
        }

        [Test, TestCaseSource("TestCasesSubBuildingMaterials")]
        public void TestSubBuildingMaterials(BuildingMaterials buildingMaterials, int num, BuildingMaterials expectedBuildingMaterials)  // Тестирование разности Food
        {
            Assert.AreEqual(expectedBuildingMaterials, buildingMaterials - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestBuildingMaterialsUnitPrice(BuildingMaterials buildingMaterials, decimal expectedUnitPrice)  // Тестирование метода UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, buildingMaterials.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestBuildingMaterialsTotalPrice(BuildingMaterials buildingMaterials, decimal expectedTotalPrice)  // Тестирование метода TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, buildingMaterials.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestBuildingMaterialsConvertToInt(BuildingMaterials buildingMaterials, int expectedInt)  // Тестирование приведения к типу int
        {
            Assert.AreEqual(expectedInt, (int)buildingMaterials);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestBuildingMaterialsConvertToDouble(BuildingMaterials buildingMaterials, double expectedDouble)  // Тестирование приведения к типу double
        {
            Assert.AreEqual(expectedDouble, (double)buildingMaterials);
        }

        [Test, TestCaseSource("TestCasesConvertToFood")]
        public void TestBuildingMaterialsConvertToFood(BuildingMaterials buildingMaterials, Food expectedFood)  // Тестирование приведеня к типу Food
        {
            Assert.AreEqual(expectedFood, (Food)buildingMaterials);
        }

        [Test, TestCaseSource("TestCasesConvertToSportGoods")]
        public void TestBuildingMaterialsConvertToSportGoods(BuildingMaterials buildingMaterials, SportGoods expectedSportGoods)  // Тестирование приведения к типу SportGoods
        {
            Assert.AreEqual(expectedSportGoods, (SportGoods)buildingMaterials);
        }

        [Test, TestCaseSource("TestCasesConvertToClothes")]
        public void TestBuildingMaterialsConvertToClothes(BuildingMaterials buildingMaterials, Clothes expectedClothes)  // Тестирование приведения к типу Clothes
        {
            Assert.AreEqual(expectedClothes, (Clothes)buildingMaterials);
        }

        [Test, TestCaseSource("TestCasesConvertToShoes")]
        public void TestBuildingMaterialsConvertToShoes(BuildingMaterials buildingMaterials, Shoes expectedShoes)  // Тестирование приведения к типу Shoes
        {
            Assert.AreEqual(expectedShoes, (Shoes)buildingMaterials);
        }
    }
}
