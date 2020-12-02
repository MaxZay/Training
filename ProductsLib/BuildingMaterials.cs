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
            int markup,
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

        public static BuildingMaterials operator +(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2) // Перегрузка оператора +
        {
            if (buildingMaterials1.Name == buildingMaterials2.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return buildingMaterials1;
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

        public static explicit operator int(BuildingMaterials buildingMaterials)  // Приведение к int
        {
            return (int)(buildingMaterials.TotalCost() * 100);
        }

        public static explicit operator double(BuildingMaterials buildingMaterials)  // Приведение к double
        {
            return (double)(buildingMaterials.TotalCost());
        }

        public static implicit operator Food(BuildingMaterials buildingMaterials) // Приведение к Food
        {
            return new Food(buildingMaterials.ProductType, buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static implicit operator SportGoods(BuildingMaterials buildingMaterials)  // Приведение к SportGoods
        {
            return new SportGoods(buildingMaterials.ProductType, buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static implicit operator Shoes(BuildingMaterials buildingMaterials)  // Приведение к Shoes
        {
            return new Shoes(buildingMaterials.ProductType, buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }

        public static implicit operator Clothes(BuildingMaterials buildingMaterials)  // Приведение к Clothes
        {
            return new Clothes(buildingMaterials.ProductType, buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }
    }
}
