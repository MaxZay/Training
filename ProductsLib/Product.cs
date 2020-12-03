using System;

namespace ProductsLib
{
    abstract public class Product : IProduct
    {
        #region Свойства
        public string ProductType { get; set; }  // Тип продукта
        public decimal PurchasePrice { get; set; }  // Закупочная цена
        public float Markup { get; set; }  // Наценка
        public int Quantity { get; set; }  // Количество единиц 
        #endregion

        public decimal UnitCost()  // Стоимость единицы товара
        {
            return Math.Round((PurchasePrice / Quantity) + (PurchasePrice / Quantity * (decimal)Markup / 100), 2);
        }
        public decimal TotalCost()  // Общая стоимость товаров
        {
            return Math.Round((((PurchasePrice / Quantity) + (PurchasePrice / Quantity * (decimal)Markup / 100)) * (decimal)Quantity), 2);
        }

        public Product(string productType,
            decimal purchasePrice,
            float markup,
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

        public override string ToString() // Переопределение ToString() 
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
