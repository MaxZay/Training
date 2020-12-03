using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class BuildingMaterials : Product
    {
        public string Name { get; set; }  // Наименование продукта

        public BuildingMaterials(string productType,
            decimal purchasePrice,
            float markup,
            int quantity, string name) : base(productType,
            purchasePrice,
            markup,
            quantity)   // Конструктор BuildingMaterials
        {
            if (name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }
        #region Перегрузка операторов
        public static BuildingMaterials operator +(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2) // Перегрузка оператора +
        {
            if (buildingMaterials1.Name == buildingMaterials2.Name)
            {
                return new BuildingMaterials(buildingMaterials1.ProductType,
                  GetNewPurchasePrice(buildingMaterials1, buildingMaterials2),
                  GetNewMarkup(buildingMaterials1, buildingMaterials2),
                  GetNewQuantity(buildingMaterials1, buildingMaterials2),
                  buildingMaterials1.Name);
            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
        }

        public static BuildingMaterials operator -(BuildingMaterials buildingMaterial, int number)  // Перегрузка оператора -
        {
            if (number > buildingMaterial.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                buildingMaterial.Quantity = buildingMaterial.Quantity - number;
                return buildingMaterial;
            }
        }

        #region Получение новых полей
        private static decimal GetNewPurchasePrice(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2)  // Получение новой закупочной цены
        {
            return (buildingMaterials1.PurchasePrice + buildingMaterials2.PurchasePrice) / 2;
        }

        private static float GetNewMarkup(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2)  // Получение новой наценки
        {
            return (buildingMaterials1.Markup + buildingMaterials2.Markup) / 2;
        }

        private static int GetNewQuantity(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2)  // Получение нового количества
        {
            return buildingMaterials1.Quantity + buildingMaterials2.Quantity;
        }
        #endregion

        #endregion

        #region Приведение типов
        public static explicit operator int(BuildingMaterials buildingMaterials)  // Приведение к int
        {
            return (int)(buildingMaterials.TotalCost() * 100);
        }

        public static explicit operator double(BuildingMaterials buildingMaterials)  // Приведение к double
        {
            return (double)(buildingMaterials.TotalCost());
        }

        public static explicit operator Food(BuildingMaterials buildingMaterials) // Приведение к Food
        {
            return new Food("Food", buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static explicit operator SportGoods(BuildingMaterials buildingMaterials)  // Приведение к SportGoods
        {
            return new SportGoods("SportGoods", buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static explicit operator Shoes(BuildingMaterials buildingMaterials)  // Приведение к Shoes
        {
            return new Shoes("Shoes", buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static explicit operator Clothes(BuildingMaterials buildingMaterials)  // Приведение к Clothes
        {
            return new Clothes("Clothes", buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }
        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            BuildingMaterials buildingMaterials = obj as BuildingMaterials;
            if (buildingMaterials == null)
            {
                return false;
            }
            return this.Markup == buildingMaterials.Markup
                && this.Name == buildingMaterials.Name
                && this.ProductType == buildingMaterials.ProductType
                && this.PurchasePrice == buildingMaterials.PurchasePrice
                && this.Quantity == buildingMaterials.Quantity;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
