using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
        fruits.Add("Pineapple");
        fruits.AddRange(new string[] { "Watermelon", "Grape" });
        Console.WriteLine(fruits[4]); 
        fruits.Remove("Orange");
        fruits.Insert(2, "Strawberry");
        Console.WriteLine(fruits[4]);

        Console.WriteLine("## Imprimido com FOR ##");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine(i + " - " + fruits[i]);
        }

        Console.WriteLine("TAMANHO ATUAL:" + fruits.Count);
        fruits.clear();
        Console.WriteLine("TAMANHO ATUAL:" + fruits.Count);
    }
}
