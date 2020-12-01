using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class SportGoods: Product
    {
        public string Name { get; set; }

        public SportGoods(string productType,
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

        public static SportGoods operator +(SportGoods sportGoods1, SportGoods sportGoods2)
        {
            if (sportGoods1.Name == sportGoods2.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return sportGoods1;
        }

        public static SportGoods operator -(SportGoods sportGoods1, int number)
        {
            if (number > sportGoods1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                sportGoods1.Quantity = sportGoods1.Quantity - number;
                return sportGoods1;
            }
        }

        public static explicit operator int(SportGoods sportGoods)
        {
            return (int)(sportGoods.TotalCost() * 100);
        }

        public static explicit operator double(SportGoods sportGoods)
        {
            return (double)(sportGoods.TotalCost());
        }
    }
}

