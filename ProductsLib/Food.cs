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
                throw new ArgumentNullException("Неворное наименование продукта");
            }
            Name = name;
        }

        public override decimal TotalCost()
        {
            return PurchasePrice + PurchasePrice * (decimal)Markup / 100;
        }

        public override decimal UnitCost()
        {
            return (PurchasePrice + PurchasePrice * (decimal)Markup / 100) * (decimal)Quantity;
        }
    }
}
