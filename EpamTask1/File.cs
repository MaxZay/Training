using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BakeryLib  //    Продукт: Батон Ингридиенты: Молоко 4 200 5 ... Наценка: 25
{                                 
    public static class File
    {
        public static Bakery ReadFromFile(string path, Bakery bakery)  // Метод для чтения данных из файла
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Production> productions = new List<Production>();
                List<Ingredient> ingredients = new List<Ingredient>();
                Production product;
                string line;
                string[] splitedLine;
                int markup;
                while ((line = sr.ReadLine()) != null)
                {
                    splitedLine = line.Split(' ');
                    markup = int.Parse(splitedLine[splitedLine.Length - 2]);
                    product = new Production(ReadNameOfProduct(splitedLine), ReadIndigrients(splitedLine), markup);
                    productions.Add(product);
                }
                bakery = new Bakery(productions.ToArray());
            }
            return bakery;
        }

        public static string ReadNameOfProduct(string[] splitedLine)
        {
            string line = "";
            for(int i = 1; i < splitedLine.Length; i++)
            {
                if(splitedLine[i] == "Ингридиенты:")
                {
                    break;
                }
                else
                {
                    line += " " + splitedLine[i];
                }
            }
            return line;
        }

        public static List<Ingredient> ReadIndigrients(string[] splitedLine)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            for(int i = Array.IndexOf(splitedLine, "Ингридиенты:") + 1; i < Array.IndexOf(splitedLine, "Наценка:");)
            {
                Ingredient ingredient = new Ingredient(splitedLine[i], decimal.Parse(splitedLine[i + 1]), float.Parse(splitedLine[i + 2]),
                    float.Parse(splitedLine[i + 3]));
                i += 4;
                ingredients.Add(ingredient);
            }
            return ingredients;
        }
    }
}
