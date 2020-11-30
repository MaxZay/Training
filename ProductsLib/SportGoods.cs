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
    }
}

