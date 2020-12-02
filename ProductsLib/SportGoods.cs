using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class SportGoods: Product
    {
        public string Name { get; set; }  // Наименование товара

        public SportGoods(string productType,
            decimal purchasePrice,
            int markup,
            int quantity, string name)   : base(productType,
            purchasePrice,
            markup,
            quantity)  // Конструктор SportGoods
        {
            if (name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }

        public static SportGoods operator +(SportGoods sportGoods1, SportGoods sportGoods2) // Перегрузка оператора +
        {
            if (sportGoods1.Name == sportGoods2.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return sportGoods1;
        }

        public static SportGoods operator -(SportGoods sportGoods1, int number)  // Перегрузка оператора - 
        {
            if (number > sportGoods1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                sportGoods1.Quantity = sportGoods1.Quantity - number;
                return sportGoods1;
            }
        }

        public static explicit operator int(SportGoods sportGoods)  // Приведение к int
        {
            return (int)(sportGoods.TotalCost() * 100);
        }

        public static explicit operator double(SportGoods sportGoods)  // Приведение к double
        {
            return (double)(sportGoods.TotalCost());
        }

        public static implicit operator Food(SportGoods sportGoods) // Приведение к Food
        {
            return new Food(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static implicit operator BuildingMaterials(SportGoods sportGoods)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static implicit operator Shoes(SportGoods sportGoods)  // Приведение к Shoes
        {
            return new Shoes(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static implicit operator Clothes(SportGoods sportGoods)  // Приведение к Clothes
        {
            return new Clothes(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

    }
}

