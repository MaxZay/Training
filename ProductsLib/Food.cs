﻿using System;
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

    }
}