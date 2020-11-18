using System;
using System.Collections.Generic;
using System.Text;

namespace BakeryLib
{
    public class Ingredient
    {
        public string IngridientName { get; set; }  // Название ингридиента
        public decimal Price { get; set; }  //  Цена за 100г
        public float CalorificValue { get; set; }  //  Калории в 100г
        public float Weight { get; set; }  // Вес

        public float RealPrice  // Цена ингридиента
        {
            get
            {
                return (float)this.Price * this.Weight / 100;
            }
        }

        public float RealCalorificValue  // Калории ингридиента
        {
            get
            {
                return this.CalorificValue * this.Weight / 100;
            }
        }

        public Ingredient(string ingridientName, decimal price, float calorificValue, float weight)  // Контруктор Ingridient
        {
            IngridientName = ingridientName;
            Price = price;
            CalorificValue = calorificValue;
            Weight = weight;
        }

        public override string ToString()  // Переопределение ToString()
        {
            return $"Цена: {Price}  Калории: {CalorificValue}  Вес: {Weight}";
        }

        public override bool Equals(object obj)  // Переопределение Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
