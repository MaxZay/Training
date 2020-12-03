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
                new Food("Food", 7.0M, 10, 7, "�����"),
                new Food("Food", 9.0M, 12, 10, "�����"),
                new Food("Food", 8.0M, 11, 17, "�����")
            },
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                new Food("Food", 7.3M, 18, 8, "�����"),
                new Food("Food", 9.9M, 16.5f, 22, "�����")
            },
            new object[]
            {
                new Food("Food", 11.8M, 20, 12, "�����"),
                new Food("Food", 9.4M, 17, 10, "�����"),
                new Food("Food", 10.6M, 18.5f, 22, "�����")
            }
        };  // ����� ������� ��� ������������ 
        public static object[] TestCasesSubFood =
        {
            new object[]
            {
                new Food("Food", 7.0M, 10, 7, "�����"),
                5,
                new Food("Food", 7.0M, 10, 2, "�����")
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 15, "�����"),
                10,
                new Food("Food", 7.0M, 10, 5, "�����")
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "�����"),
                1,
                new Food("Food", 7.0M, 10, 2, "�����")
            },
        }; // ����� ������� ��� ������������
        public static object[] TestCasesUnitPrice =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                1.03M
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "�����"),
                2.57M
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                1.6M
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesTotalPrice =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                14.38M
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "�����"),
                7.7M
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                11.2M
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToInt =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                1438
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "�����"),
                770
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                1120
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToDouble =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                14.38
            },
            new object[]
            {
                new Food("Food", 7.0M, 10, 3, "�����"),
                7.70
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                11.20
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToSportGoods =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                new SportGoods("SportGoods", 12.5M, 15, 14, "�����")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "�����"),
                new SportGoods("SportGoods", 15.1M, 21, 12, "�����")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                new SportGoods("SportGoods", 10.0M, 12, 7, "�����")
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToClothes =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                new Clothes("Clothes", 12.5M, 15, 14, "�����")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "�����"),
                new Clothes("Clothes", 15.1M, 21, 12, "�����")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                new Clothes("Clothes", 10.0M, 12, 7, "�����")
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToShoes =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                new Shoes("Shoes", 12.5M, 15, 14, "�����")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "�����"),
                new Shoes("Shoes", 15.1M, 21, 12, "�����")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                new Shoes("Shoes", 10.0M, 12, 7, "�����")
            }
        };  // ����� ������� ��� ������������
        public static object[] TestCasesConvertToBuildingMaterials =
        {
             new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),
                new BuildingMaterials("BuildingMaterials", 12.5M, 15, 14, "�����")
            },
            new object[]
            {
                new Food("Food", 15.1M, 21, 12, "�����"),
                new BuildingMaterials("BuildingMaterials", 15.1M, 21, 12, "�����")
            },
            new object[]
            {
                new Food("Food", 10.0M, 12, 7, "�����"),
                new BuildingMaterials("BuildingMaterials", 10.0M, 12, 7, "�����")
            }
        };  // ����� ������� ��� ������������

        [Test, TestCaseSource("TestCasesSumFood")]
        public void TestSumFood(Food food1, Food food2, Food expectedFood)  // ������������ ����� Food
        {
            Assert.AreEqual(expectedFood, food1 + food2);
        }

        [Test, TestCaseSource("TestCasesSubFood")]
        public void TestSubFood(Food food1, int num, Food expectedFood)  // ������������ �������� Food
        {
            Assert.AreEqual(expectedFood, food1 - num);
        }

        [Test, TestCaseSource("TestCasesUnitPrice")]
        public void TestFoodUnitPrice(Food food, decimal expectedUnitPrice)  // ������������ ������ UnitCost
        {
            Assert.AreEqual(expectedUnitPrice, food.UnitCost());
        }

        [Test, TestCaseSource("TestCasesTotalPrice")]
        public void TestFoodTotalPrice(Food food, decimal expectedTotalPrice)  // ������������ ������ TotalCost
        {
            Assert.AreEqual(expectedTotalPrice, food.TotalCost());
        }

        [Test, TestCaseSource("TestCasesConvertToInt")]
        public void TestFoodConvertToInt(Food food, int expectedInt)  // ������������ ���������� � ���� int
        {
            Assert.AreEqual(expectedInt, (int)food);
        }

        [Test, TestCaseSource("TestCasesConvertToDouble")]
        public void TestFoodConvertToDouble(Food food, double expectedDouble)  // ������������ ���������� � ���� double
        {
            Assert.AreEqual(expectedDouble, (double)food);
        }

        [Test, TestCaseSource("TestCasesConvertToSportGoods")]
        public void TestFoodConvertToSportGoods(Food food, SportGoods expectedSportGoods)  // ������������ ��������� � ���� SportGoods
        {
            Assert.AreEqual(expectedSportGoods, (SportGoods)food);
        }

        [Test, TestCaseSource("TestCasesConvertToClothes")]
        public void TestFoodConvertToClothes(Food food, Clothes expectedClothes)  // ������������ ���������� � ���� Clothes
        {
            Assert.AreEqual(expectedClothes, (Clothes)food);
        }

        [Test, TestCaseSource("TestCasesConvertToShoes")]
        public void TestFoodConvertToShoes(Food food, Shoes expectedShoes)  // ������������ ���������� � ���� Shoes
        {
            Assert.AreEqual(expectedShoes, (Shoes)food);
        }

        [Test, TestCaseSource("TestCasesConvertToBuildingMaterials")]
        public void TestFoodConvertToBuildingMaterials(Food food, BuildingMaterials expectedBuildingMaterials)  // ������������ ���������� � ���� BuildingMaterials
        {
            Assert.AreEqual(expectedBuildingMaterials, (BuildingMaterials)food);
        }







    }
}