using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator c = new Calculator();

        int sum1 = c.Add(5, 8);
        int sum2 = c.Add(5, 8, 10);
        double sum3 = c.Add(5.5, 8.3);

        Console.WriteLine("Soma de dois números inteiros: " + sum1);
        Console.WriteLine("Soma de três números inteiros: " + sum2);
        Console.WriteLine("Soma de dois números reais: " + sum3);
    }
}
