using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Shoes: Product
    {
        public string Name { get; set; }  // Наименование товара

        public Shoes(string productType,
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

        public static Shoes operator +(Shoes shoes1, Shoes shoes2)  // Перегрузка оператора +
        {
            if (shoes1.Name == shoes2.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return shoes1;
        }

        public static Shoes operator -(Shoes shoes1, int number)  // Перегрузка оператора -
        {
            if (number > shoes1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                shoes1.Quantity = shoes1.Quantity - number;
                return shoes1;
            }
        }

        public static explicit operator int(Shoes shoes)  // Приведение к int
        {
            return (int)(shoes.TotalCost() * 100);
        }

        public static explicit operator double(Shoes shoes)  // Приведение к double
        {
            return (double)(shoes.TotalCost());
        }

        public static implicit operator Food(Shoes shoes) // Приведение к Food
        {
            return new Food(shoes.ProductType, shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static implicit operator BuildingMaterials(Shoes shoes)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials(shoes.ProductType, shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static implicit operator SportGoods(Shoes shoes)  // Приведение к SportGoods
        {
            return new SportGoods(shoes.ProductType, shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static implicit operator Clothes(Shoes shoes)  // Приведение к Clothes
        {
            return new Clothes(shoes.ProductType, shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

    }
}
