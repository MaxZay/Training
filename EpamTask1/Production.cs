using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTask1
{
    public class Production
    {
        public List<Ingredient> Ingredients { get; set; }  // Список ингридиентов 
                                                                                      
        public int Markup { get; set; }  // Наценка
        public Production(List<Ingredient> ingredients,int markup)  // Конструктор Production
        {
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
            return price * Markup / 100 + price;
        }

        public override string ToString()  // Переопределение ToString()
        {
            return string.Join(" ", Ingredients) + " " + Markup.ToString();
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
