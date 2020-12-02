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
        #region Перегрезка операторов
        public static Shoes operator +(Shoes shoes1, Shoes shoes2)  // Перегрузка оператора +
        {
            if (shoes1.Name == shoes2.Name)
            {
                return new Shoes(shoes1.ProductType,
                 GetNewPurchasePrice(shoes1, shoes2),
                 GetNewMarkup(shoes1, shoes2),
                 GetNewQuantity(shoes1, shoes2),
                 shoes1.Name);
            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
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

        #region Получение новых полей
        private static decimal GetNewPurchasePrice(Shoes shoes1, Shoes shoes2)  // Получение новой закупочной цены
        {
            return (shoes1.PurchasePrice + shoes2.PurchasePrice) / (decimal)(shoes1.Quantity + shoes2.Quantity);
        }

        private static int GetNewMarkup(Shoes shoes1, Shoes shoes2)  // Получение новой наценки
        {
            return (shoes1.Markup + shoes2.Markup) / (shoes1.Quantity + shoes2.Quantity);
        }

        private static int GetNewQuantity(Shoes shoes1, Shoes shoes2)  // Получение нового количества
        {
            return shoes1.Quantity + shoes2.Quantity;
        }
        #endregion
        #endregion

        #region Приведение к типам

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
        #endregion

    }
}
