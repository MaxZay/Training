using NUnit.Framework;
using ProductsLib;
using System.Collections.Generic;

namespace ProductLigTest
{
    [TestFixture]
    public class TestingFoodClass
    {
        [SetUp]
        public void Setup()
        {
        }
        public static IEnumerable<Food> TestCasesFood() {
            yield return new Food("Food", 7.0M, 10, 7, "Батон");
            yield return new Food("Food", 9.0M, 12, 10, "Батон");
        }
        Food food1 = new Food("Food", 7.0M, 10, 7, "Батон");
        Food food2 = new Food("Food", 9.0M, 12, 10, "Батон");
        Food food3 = new Food("Food", 12.5M, 15, 14, "Батон");
        Food food4 = new Food("Food", 7.3M, 18, 8, "Батон");
        Food food5 = new Food("Food", 11.8M, 20, 12, "Батон");
        Food food6 = new Food("Food", 9.4M, 17, 10, "Батон");


        [Test, TestCaseSource(nameof(TestCasesFood))]
        public void TestSumFood()
        {
            
        }
    }
}