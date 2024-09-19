using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> idades = new Dictionary<string, int>
        {
            {"João", 20},
            {"Maria", 18},
            {"Pedro", 25}
        };

        idades.Add("Alice", 25);
        idades.Add("Bob", 30);
        idades.Add("Jhon", 28);

        Console.WriteLine("Pedro tem " + idades["Pedro"] + " anos");

        if (idades.ContainsKey("Renato"))
        {
            Console.WriteLine("Eu sei a idade de Renato");
        }
        else
        {
            Console.WriteLine("Eu não sei a idade de Renato");
        }

        if (idades.ContainsKey("Alice"))
        {
            Console.WriteLine("Eu sei a idade de Alice");
        }
        else
        {
            Console.WriteLine("Eu não sei a idade de Alice");
        }

        foreach (KeyValuePair<string, int> par in idades)
        {
            Console.WriteLine(par.Key + " tem " + par.Value + " anos");
        }

        foreach (string nome in idades.Keys)
        {
            Console.WriteLine(nome + " possui " + idades[nome] + " anos");
        }

     
        Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas");

        
        idades.Clear();
      
        Console.WriteLine("Sabemos a idade de " + idades.Count + " pessoas");
    }
}
