using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;

namespace BakeryLib  
{                                 
    public static class File
    {
        public static Bakery ReadFromFile(string path) // метод для чтения данных из файла
        {
            Bakery bakery;
            using (StreamReader sr = new StreamReader(path))
            {
                List<Production> products = new List<Production>();
                List<Ingredient> ingredients = new List<Ingredient>();
                NumberFormatInfo nfi = new NumberFormatInfo() { NumberDecimalSeparator = "." };
                Ingredient ingredient;
                Production product;
                string line = "";
                string[] splitedLine;
                string nameProduct = "", nameIngridient;
                bool flag = false;
                int markup = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line[0] != ' ')
                    {
                        if(flag == true)
                        {
                            product = new Production(nameProduct, ingredients, markup);
                            flag = false;
                            ingredients.Clear();
                            products.Add(product);
                        }
                        splitedLine = line.Split(' ');
                        nameProduct = string.Join(" ", splitedLine.Where(u => Array.IndexOf(splitedLine, u) != splitedLine.Length - 1));
                        markup = int.Parse(splitedLine[splitedLine.Length - 1]);
                    }
                    else
                    {
                        splitedLine = line.Trim().Split(' ');
                        nameIngridient = string.Join(" ", splitedLine.TakeWhile(u => u.ToCharArray().All(char.IsLetter)));
                        flag = true;
                        ingredient = new Ingredient(nameIngridient, decimal.Parse(splitedLine[splitedLine.Length - 3], nfi), float.Parse(splitedLine[splitedLine.Length - 2]), 
                            float.Parse(splitedLine[splitedLine.Length - 1]));
                        ingredients.Add(ingredient);
                    }
                }
                bakery = new Bakery(products.ToArray());
            }
            return bakery;
        }
    }
}
