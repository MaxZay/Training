using System;
using System.Collections.Generic;

namespace EpamTask1
{
    public class Bakery
    {
        List<Production> Products { get; set; }  // Список продукции

        public override string ToString()  // Переопределение ToString()
        {
            return string.Join(" ", Products);
        }

        public override bool Equals(object obj)  // Переопределение Equals()
        {
            Bakery bakery = (Bakery)obj;
            return bakery.Products == this.Products;
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                foreach (Production product in Products)
                {
                    hash = hash * 31 + product.GetHashCode();
                }
                return hash;
            }
        }
    }
}
