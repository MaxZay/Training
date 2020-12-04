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
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                for(int i = 0; i < products.Count; i++)
                {
                    var jsonFormatter = new DataContractJsonSerializer(products[i].GetType());
                    jsonFormatter.WriteObject(fs, products[i]);
                    
                }
                
            }
        }

        public static List<Product> Read(string fileName)
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
            using(FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                var newProducts = jsonFormatter.ReadObject(fs) as List<Product>;
                return (List<Product>)newProducts;
            }
            
        }
    }
}

    
