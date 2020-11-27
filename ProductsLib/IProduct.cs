using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsLib
{
    interface IProduct
    {
        decimal UnitCost();
        decimal TotalCost();
    }
}
