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

        #region Перегрузка операторов
        public static Clothes operator +(Clothes clothes1, Clothes clothes2)  // Перегрузка оператора +
        {
            if (clothes1.Name == clothes1.Name)
            {
                return new Clothes(clothes1.ProductType,
                 GetNewPurchasePrice(clothes1, clothes2),
                 GetNewMarkup(clothes1, clothes2),
                 GetNewQuantity(clothes1, clothes2),
                 clothes1.Name);
            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
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

        #region Получение новых полей
        private static decimal GetNewPurchasePrice(Clothes clothes1, Clothes clothes2)  // Получение новой закупочной цены
        {
            return (clothes1.PurchasePrice + clothes2.PurchasePrice) / 2M;
        }

        private static float GetNewMarkup(Clothes clothes1, Clothes clothes2)  // Получение новой наценки
        {
            return (clothes1.Markup + clothes2.Markup) / 2;
        }

        private static int GetNewQuantity(Clothes clothes1, Clothes clothes2)  // Получение нового количества
        {
            return clothes1.Quantity + clothes2.Quantity;
        }
        #endregion

        #endregion

        #region Приведение типов
        public static explicit operator int(Clothes clothes)  // Приведение к int
        {
            return (int)(clothes.TotalCost() * 100);
        }

        public static explicit operator double(Clothes clothes)  // Приведение к double
        {
            return (double)(clothes.TotalCost());
        }

        public static explicit operator Food(Clothes clothes) // Приведение к Food
        {
            return new Food("Food", clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static explicit operator SportGoods(Clothes clothes)  // Приведение к SportGoods
        {
            return new SportGoods("SportGoods", clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static explicit operator Shoes(Clothes clothes)  // Приведение к Shoes
        {
            return new Shoes("Shoes", clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        public static explicit operator BuildingMaterials(Clothes clothes)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials("BuildingMaterials", clothes.PurchasePrice, clothes.Markup, clothes.Quantity, clothes.Name);
        }

        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
