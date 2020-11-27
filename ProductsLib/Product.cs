using System;

namespace ProductsLib
{
    abstract public class Product : IProduct
    {
        #region Свойства
        public string ProductType { get; set; }  // Наименование продукта
        public decimal PurchasePrice { get; set; }  // Закупочная цена
        public int Markup { get; set; }  // Наценка
        public int Quantity { get; set; }  // Количество единиц 
        #endregion

        abstract public decimal UnitCost();
        abstract public decimal TotalCost();

        public Product(string productType,
            decimal purchasePrice,
            int markup,
            int quantity)
        {
            #region Проверка условий
            if (productType == null)
            {
                throw new ArgumentNullException("Неверный тип продукта.");
            }

            if (purchasePrice <= 0)
            {
                throw new ArgumentException("Невозможная закупочная цена.");
            }

            if (markup < 0)
            {
                throw new ArgumentException("Невозможная наценка.");
            }

            if (quantity <= 0)
            {
                throw new ArgumentException("Невозможное количество единиц товара");
            }
            #endregion

            ProductType = productType;
            PurchasePrice = purchasePrice;
            Markup = markup;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
