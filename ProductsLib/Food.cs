using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    public class Food : Product
    {
        public string Name { get; set; }  // Наименование товара
        public Food(string productType,
            decimal purchasePrice,
            int markup,
            int quantity, string name) : base(productType, 
            purchasePrice,
            markup,
            quantity)
        { 
            if(name == null)
            {
                throw new ArgumentNullException("Неверное наименование продукта");
            }
            Name = name;
        }

        public static Food operator +(Food food1, Food food2)
        {
            if(food1.Name == food1.Name)
            {

            }
            else
            {
                throw new Exception("Не совпадают наименования продукта");
            }
            return food1;
        }

        public static Food operator - (Food food1, int number)
        {
            if(number > food1.Quantity)
            {
                throw new Exception("Отнимаемое число больше чем количество товара");
            }
            else
            {
                food1.Quantity = food1.Quantity - number;
                return food1;
            }
        }
    
        public override int ToInt()
        {
            return (int)(this.TotalCost() * 100);
        }

        public override double ToDouble()
        {
            return (double)(this.TotalCost());
        }


    }
}
