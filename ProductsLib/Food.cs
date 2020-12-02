﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Food : Product
    {
        public string Name { get; set; }  // Наименование товара
        public Food(string productType,
            decimal purchasePrice,
            int markup,
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

        private static decimal GetNewPurchasePrice(Food food1, Food food2)  // Получение новой закупочной цены
        {
            return (food1.PurchasePrice + food2.PurchasePrice) / (decimal)(food1.Quantity + food2.Quantity);
        }

        #region Получение новых полей
        private static int GetNewMarkup(Food food1, Food food2)  // Получение новой наценки
        {
            return (food1.Markup + food2.Markup) / (food1.Quantity + food2.Quantity);
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

        public static implicit operator SportGoods(Food food) // Приведение к SportGoods
        {
            return new SportGoods(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static implicit operator BuildingMaterials(Food food)  // Приведение к BuildingMaterials
        {
            return new BuildingMaterials(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static implicit operator Shoes(Food food)  // Приведение к Shoes
        {
            return new Shoes(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }

        public static implicit operator Clothes(Food food)  // Приведение к Clothes
        {
            return new Clothes(food.ProductType, food.PurchasePrice, food.Markup, food.Quantity, food.Name);
        }
        #endregion


    }
}
