using System;
using System.Collections.Generic;

namespace BakeryLib
{
    public class Bakery
    {
        public Production[] Products { get; set; }  // Список продукции

        public Bakery(Production[] products)  // Конструктор Bakery
        {
            Products = products;
        }

        public  override string ToString()  // Переопределение ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)  // Переопределение Equals()
        {
            Bakery b = obj as Bakery;
            if (b == null)
            {
                return false;
            }
            for(int i = 0; i < b.Products.Length; i++)
            {
                if(b.Products[i].Markup == this.Products[i].Markup 
                    && Products[i].ProductName == this.Products[i].ProductName)
                {
                    for (int j = 0; j < b.Products[i].Ingredients.Count; j++)
                    {
                        if (b.Products[i].Ingredients[j].CalorificValue != this.Products[i].Ingredients[j].CalorificValue
                            || b.Products[i].Ingredients[j].IngridientName != this.Products[i].Ingredients[j].IngridientName
                            || b.Products[i].Ingredients[j].Price != this.Products[i].Ingredients[j].Price
                            || b.Products[i].Ingredients[j].Weight != this.Products[i].Ingredients[j].Weight)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
             return base.GetHashCode();
        }
    }
}
