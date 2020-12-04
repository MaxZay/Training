using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ProductsLib
{
    public static class WorkWithFile
    {
        public static void Save(List<Product> products, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                for(int i = 0; i < products.Count; i++)
                {
                    string json = JsonConvert.SerializeObject(products[i]);
                    if (i == products.Count - 1)
                    {
                        sw.Write(json);
                        break;
                    }
                    sw.WriteLine(json);
                }
                
            }
        }

        public static List<Product> Read(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    List<Product> products = new List<Product>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parseDot = line.Split(',');
                        string[] parseType = parseDot[1].Split(':');
                        string type = parseType[1].Replace($"{(char)34}", "");
                        Type productType = TakeType(type);
                        if (productType == null)
                        {
                            throw new ArgumentNullException("Неверный тип");
                        }
                        else
                        {
                            var product = JsonConvert.DeserializeObject(line, productType);
                            products.Add((Product)product);
                        }
                    }
                    return products;
                }
            }
            catch
            {
                throw new Exception("Ошибка чтения из файла");
            }
        }

        private static Type TakeType(string str)
        {
            switch (str)
            {
                case "Food": return typeof(Food);
                case "Clothes": return typeof(Clothes);
                case "Shoes": return typeof(Shoes);
                case "SportGoods": return typeof(SportGoods);
                case "BuildingMaterials": return typeof(BuildingMaterials);
                default: return null;
            }
        }
    }
}

    
