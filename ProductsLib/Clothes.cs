using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Clothes: Product
    {
        public string Name { get; set; }  // Наименование продукта

        public Clothes(string productType,
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

        public static Clothes operator +(Clothes clothes1, Clothes clothes2)  // Перегрузка оператора +
        {
            if (clothes1.Name == clothes1.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return clothes1;
        }

        public static Clothes operator -(Clothes clothes1, int number)  // Перегрузка оператора -
        {
            if (number > clothes1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                clothes1.Quantity = clothes1.Quantity - number;
                return clothes1;
            }
        }

        public static explicit operator int(Clothes clothes)  // Приведение к int
        {
            return (int)(clothes.TotalCost() * 100);
        }

        public static explicit operator double(Clothes clothes)  // Приведение к double
        {
            return (double)(clothes.TotalCost());
        }

        public static implicit operator Food(Clothes clothes) // Приведение к Food
        {
            return new Food(clothes.ProductType, clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static implicit operator SportGoods(Clothes clothes)  // Приведение к SportGoods
        {
            return new SportGoods(clothes.ProductType, clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static implicit operator Shoes(Clothes clothes)  // Приведение к Shoes
        {
            return new Shoes(clothes.ProductType, clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static implicit operator Clothes(BuildClothesingMaterials buildingMaterials)  // Приведение к Clothes
        {
            return new Clothes(buildingMaterials.ProductType, buildingMaterials.PurchasePrice, buildingMaterials.Markup, buildingMaterials.Quantity, buildingMaterials.Name);
        }
    }
}
