using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization.Json;

namespace ProductsLib
{
    public static class WorkWithFile
    {
        public static void Save(List<Product> products, string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
            using (FileStream fs = new FileStream("ProductsInfo.txt", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, products);
            }
        }

        public static List<Product> Read(string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
            using(FileStream fs = new FileStream("ProductsInfo.txt", FileMode.OpenOrCreate))
            {
                var newProducts = jsonFormatter.ReadObject(fs) as List<Product>;
                return (List<Product>)newProducts;
            }
            
        }
    }
}

    
