using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    static public class ProductsInfo<T> where T: Product
    {
        public static List<T> Products { get; set; }
    }
}
