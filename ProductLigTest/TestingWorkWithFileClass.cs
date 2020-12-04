using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProductsLib;

namespace ProductLigTest
{
    [TestFixture]
    public class TestingWorkWithFileClass
    {
        [Test]
        public void TestSaveInFile()
        {
            List<Product> productInfoSave = new List<Product>()
            {
                new Food("Food", 120.0M, 14, 60, "Хлеб"),
                new SportGoods("SportGoods", 175.0M, 20, 10, "Мяч"),
                new BuildingMaterials("BuildingMaterials", 600.0M, 15, 30, "Бетон")
            };
            List<Product> productInfoRead = new List<Product>();
            WorkWithFile.Save(productInfoSave, @"C:\Users\maxim\Documents\EPAM\Решения\EpamTask2\ProductsLib\ProductsInfo.txt");
    //        productInfoSave = WorkWithFile.Read("productInfo.txt");

            Assert.AreEqual(productInfoSave, productInfoRead);
        }
    }
}
