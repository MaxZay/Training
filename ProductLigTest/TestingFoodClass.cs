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
        public static object[] TestCasesUnitPrise =
        {
            new object[]
            {
                new Food("Food", 12.5M, 15, 14, "�����"),0.8928
            }
        };

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

        [Test, TestCaseSource("")]
        public void TestFoodUnitPrice()
        {

        }


    }
}