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
            float markup,
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
            return (shoes1.PurchasePrice + shoes2.PurchasePrice) / 2;
        }

        private static float GetNewMarkup(Shoes shoes1, Shoes shoes2)  // Получение новой наценки
        {
            return (shoes1.Markup + shoes2.Markup) / 2;
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

        public static explicit operator Food(Shoes shoes) // Приведение к Food
        {
            return new Food("Food", shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static explicit operator BuildingMaterials(Shoes shoes)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials("BuildingMaterials", shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static explicit operator SportGoods(Shoes shoes)  // Приведение к SportGoods
        {
            return new SportGoods("SportGoods", shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }

        public static explicit operator Clothes(Shoes shoes)  // Приведение к Clothes
        {
            return new Clothes("Clothes", shoes.PurchasePrice, shoes.Markup, shoes.Quantity, shoes.Name);
        }
        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Shoes shoes = obj as Shoes;
            if (shoes == null)
            {
                return false;
            }
            return this.Markup == shoes.Markup
                && this.Name == shoes.Name
                && this.ProductType == shoes.ProductType
                && this.PurchasePrice == shoes.PurchasePrice
                && this.Quantity == shoes.Quantity;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
