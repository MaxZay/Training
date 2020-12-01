using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Shoes: Product
    {
        public string Name { get; set; }  // Наименование товара

        public Shoes(string productType,
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

        public static Shoes operator +(Shoes shoes1, Shoes shoes2)
        {
            if (shoes1.Name == shoes2.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return shoes1;
        }

        public static Shoes operator -(Shoes shoes1, int number)
        {
            if (number > shoes1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                shoes1.Quantity = shoes1.Quantity - number;
                return shoes1;
            }
        }

        public static explicit operator int(Shoes shoes)
        {
            return (int)(shoes.TotalCost() * 100);
        }

        public static explicit operator double(Shoes shoes)
        {
            return (double)(shoes.TotalCost());
        }
        
    }
}
