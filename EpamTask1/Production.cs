using System;
using System.Collections.Generic;
using System.Text;

namespace EpamTask1
{
    public class Production
    {
        public List<Ingredient> Ingredients { get; set; }  // Список ингридиентов
        
        public Production(List<Ingredient> ingredients)
        {
            Ingredients = ingredients;
        } 
        public override string ToString()  // Переопределение ToString()
        {
            return string.Join(" ", Ingredients);
        }

        public override bool Equals(object obj)  // Переопределение Equals(object obj)
        {
            Production production = (Production)obj;
            return production.Ingredients == this.Ingredients;
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    
}
