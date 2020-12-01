using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class BuildingMaterials : Product
    {
        public string Name { get; set; }

        public BuildingMaterials(string productType,
            decimal purchasePrice,
            int markup,
            int quantity, string name) : base(productType,
            purchasePrice,
            markup,
            quantity)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }

        public static BuildingMaterials operator +(BuildingMaterials buildingMaterials1, BuildingMaterials buildingMaterials2)
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

        public static BuildingMaterials operator -(BuildingMaterials buildingMaterial, int number)
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

        public static explicit operator int(BuildingMaterials buildingMaterials)
        {
            return (int)(buildingMaterials.TotalCost() * 100);
        }

        public static explicit operator double(BuildingMaterials buildingMaterials)
        {
            return (double)(buildingMaterials.TotalCost());
        }
    }
}
