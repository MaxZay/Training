using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Clothes: Product
    {
        public string Name { get; set; }

        public Clothes(string productType,
            decimal purchasePrice,
            int markup,
            int quantity, string name) : base(productType,
            purchasePrice,
            markup,
            quantity)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }

        public static Clothes operator +(Clothes clothes1, Clothes clothes2)
        {
            if (clothes1.Name == clothes1.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return clothes1;
        }

        public static Clothes operator -(Clothes clothes1, int number)
        {
            if (number > clothes1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                clothes1.Quantity = clothes1.Quantity - number;
                return clothes1;
            }
        }
    }
}
