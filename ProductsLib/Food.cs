using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Food : Product
    {
        public string Name { get; set; }  // Наименование товара
        public Food(string productType,
            decimal purchasePrice,
            float markup,
            int quantity, string name) : base(productType, 
            purchasePrice,
            markup,
            quantity)
        { 
            if(name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }

        #region Перегрузка операторов
        public static Food operator +(Food food1, Food food2)  // Перегрузка оператора +
        {
            if(food1.Name == food1.Name)
            {
                return new Food(food1.ProductType, 
                    GetNewPurchasePrice(food1, food2), 
                    GetNewMarkup(food1, food2), 
                    GetNewQuantity(food1, food2),
                    food1.Name);
            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
        }      

        public static Food operator - (Food food1, int number) // Перегрузка оператора -
        {
            if(number > food1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                food1.Quantity = food1.Quantity - number;
                return food1;
            }
        }

        #region Получение новых полей
        private static decimal GetNewPurchasePrice(Food food1, Food food2)  // Получение новой закупочной цены
        {
            return (food1.PurchasePrice + food2.PurchasePrice) / 2.0M;
        }
        private static float GetNewMarkup(Food food1, Food food2)  // Получение новой наценки
        {
            return (food1.Markup + food2.Markup) / 2;
        }

        private static int GetNewQuantity(Food food1, Food food2)  // Получение нового количества
        {
            return food1.Quantity + food2.Quantity;
        }
        #endregion
        #endregion

        #region Приведение типов

        public static explicit operator int(Food food) // Приведение к int
        {
            return (int)(food.TotalCost() * 100);
        }

        public static explicit operator double(Food food) // Приведение к double
        {
            return (double)(food.TotalCost());
        }

        public static explicit operator SportGoods(Food food) // Приведение к SportGoods
        {
            return new SportGoods(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static explicit operator BuildingMaterials(Food food)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static explicit operator Shoes(Food food)  // Приведение к Shoes
        {
            return new Shoes(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static explicit operator Clothes(Food food)  // Приведение к Clothes
        {
            return new Clothes(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        #endregion

        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            Food food = obj as Food;
            if(food == null)
            {
                return false;
            }
            return this.Markup == food.Markup
                && this.Name == food.Name
                && this.ProductType == food.ProductType
                && this.PurchasePrice == food.PurchasePrice
                && this.Quantity == food.Quantity;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
