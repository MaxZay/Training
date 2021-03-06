﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    public class Production
    {
        public string ProductName { get; set; }  // Название продукта
        public List<Ingredient> Ingredients { get; set; }  // Список ингридиентов                                                                   
        public int Markup { get; set; }  // Наценка
        public float Weight
        {
            get
            {
                float weight = 0;
                foreach(Ingredient ingredient in Ingredients)
                {
                    weight += ingredient.Weight;
                }
                return weight;
            }
        }
        public Production(string productName, List<Ingredient> ingredients,int markup)  // Конструктор Production
        {
            ProductName = productName;
            Ingredients = ingredients;
            Markup = markup;
        } 
        
        public float GetCalorificValue()  // Метод для вычисления калорийности продукта
        {
            float calorificValue = 0;
            foreach(Ingredient ingredient in Ingredients)
            {
                calorificValue += ingredient.RealCalorificValue;
            }
            return calorificValue;
        }
       
        public decimal GetPrice()  // Метод для вычисления цены продукта
        {
            decimal price = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                price += (decimal)ingredient.RealPrice;
            }
            return Math.Round(price + price * Markup / 100, 2);
        }

        public override string ToString()  // Переопределение ToString()
        {
            return $"{this.ProductName}: {string.Join(" ", Ingredients)} {Markup}";
        }

        public override bool Equals(object obj)  // Переопределение Equals(object obj)
        {
             Production pr = obj as Production;
             if(pr == null)
             {
                 return false;
             }
            return pr.Ingredients == this.Ingredients && pr.Markup == this.Markup && pr.ProductName == this.ProductName;
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
