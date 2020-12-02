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
            float markup,
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
        #region Перегрузка операторов
        public static SportGoods operator +(SportGoods sportGoods1, SportGoods sportGoods2) // Перегрузка оператора +
        {
            if (sportGoods1.Name == sportGoods2.Name)
            {
                return new SportGoods(sportGoods1.ProductType,
                    GetNewPurchasePrice(sportGoods1, sportGoods2),
                    GetNewMarkup(sportGoods1, sportGoods2),
                    GetNewQuantity(sportGoods1, sportGoods2),
                    sportGoods1.Name);
            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
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

        #region Получение новых полей
        private static decimal GetNewPurchasePrice(SportGoods sportGoods1, SportGoods sportGoods2)  // Получение новой закупочной цены
        {
            return (sportGoods1.PurchasePrice + sportGoods2.PurchasePrice) / 2;
        }

        private static float GetNewMarkup(SportGoods sportGoods1, SportGoods sportGoods2)  // Получение новой наценки
        {
            return (sportGoods1.Markup + sportGoods2.Markup) / 2;
        }

        private static int GetNewQuantity(SportGoods sportGoods1, SportGoods sportGoods2)  // Получение нового количества
        {
            return sportGoods1.Quantity + sportGoods2.Quantity;
        }
        #endregion

        #endregion

        #region Приведение к типам

        public static explicit operator Food(SportGoods sportGoods) // Приведение к Food
        {
            return new Food(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }
   
        public static explicit operator BuildingMaterials(SportGoods sportGoods)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static explicit operator Shoes(SportGoods sportGoods)  // Приведение к Shoes
        {
            return new Shoes(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static explicit operator Clothes(SportGoods sportGoods)  // Приведение к Clothes
        {
            return new Clothes(sportGoods.ProductType, sportGoods.PurchasePrice, sportGoods.Markup, sportGoods.Quantity, sportGoods.Name);
        }

        public static explicit operator int(SportGoods sportGoods)  // Приведение к int
        {
            return (int)(sportGoods.TotalCost() * 100);
        }

        public static explicit operator double(SportGoods sportGoods)  // Приведение к double
        {
            return (double)(sportGoods.TotalCost());
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

