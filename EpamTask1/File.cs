using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BakeryLib   //    Продукт: Батон Ингридиенты: Молоко 4 200 5 ... Наценка: 25
{
    public static class File
    {
        public static Bakery ReadFromFile(string path, Bakery bakery)  // Метод для чтения данных из файла
        {
            using (StreamReader sr = new StreamReader(path))
            {
                List<Production> productions = new List<Production>();
                List<Ingredient> ingredients = new List<Ingredient>();
                Ingredient ingridient;
                Production product;
                string line;
                string[] splitedLine;
                while((line = sr.ReadLine()) != null)
                {
                    splitedLine = line.Split(' ');
                    for(int i = 3; i < splitedLine.Length; i++)
                    {
                        ingredient = new 
                    }
                }
            }
            return bakery;
        }
    }
}
