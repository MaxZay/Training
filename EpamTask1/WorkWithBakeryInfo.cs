using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BakeryLib
{
    public static class WorkWithArray
    {
        public static Production[] OrderByCalorificValue(Bakery bakery)  // Метод для сортировки изделий по калорийности
        {
            Production[] products = (Production[])bakery.Products.Clone();
            return products.OrderBy(u => u.GetCalorificValue()).ToArray();
        }

        public static Production[] OrderByPrice(Bakery bakery)  // Метод для сортировки изделий по цене
        {
            Production[] products = (Production[])bakery.Products.Clone();
            return products.OrderBy(u => u.GetPrice()).ToArray();
        }

        public static Production[] FindProductsEqualsByPriceAndCalorificValue(Bakery bakery, decimal price, float calorificValue)  // Метод для нахождения всех изделий равных заданной
            // цене и калорийности
        {
            return bakery.Products.Where(u => u.GetPrice() == price && u.GetCalorificValue() == calorificValue).ToArray();
        }

        public static Production[] FindProductsByVolume(Bakery bakery, Ingredient ingredient, int value)  // Метод для нахождения изделий у которых объём использования заданного ингредиента
  //          больше указанной величины  
        {
            float ingredientVolume;
            List<Production> outProduct = new List<Production>();
            foreach(Production production in bakery.Products)
            {
                foreach(Ingredient ing in production.Ingredients)
                {
                    if (ing.IngridientName == ingredient.IngridientName)
                    {
                        ingredientVolume = ing.Weight * 100 / production.Weight;
                        if (ingredientVolume > value)
                        {
                            outProduct.Add(production);
                        }
                    }
                }
            }
            return outProduct.ToArray();
        }

        public static Production[] FindProductsCountMoreThanNumber(Bakery bakery, int value) // Метод для нахождения изделий  у которых число ингредиентов больше заданной величины 
        {
            return bakery.Products.Where(u => u.Ingredients.Count > value).ToArray();
        }

    }
}
