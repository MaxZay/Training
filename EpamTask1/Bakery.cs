using System;
using System.Collections.Generic;

namespace EpamTask1
{
    public class Bakery
    {
        List<Production> Products { get; set; }  // Список продукции

        public Bakery(List<Production> products)  // Конструктор Bakery
        {
            Products = products;
        }

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
            return base.GetHashCode();
        }
    }
}
