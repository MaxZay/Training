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
            return base.Equals(obj);
        }

        public override int GetHashCode()  // Переопределение GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
