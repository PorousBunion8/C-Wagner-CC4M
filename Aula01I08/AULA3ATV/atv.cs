// using.System;
// using.System.Collections.Generic;

// using System;

// class Calculator
// {
//     public int Add(int a, int b)
//     {
//         return a + b;
//     }

//     public int Add(int a, int b, int c)
//     {
//         return a + b + c;
//     }

//     public double Add(double a, double b)
//     {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

using System;

class Carro{
  
    public int CalcularPosicaoMRU(int posicaoInicial, int velocidade, int tempo){
        return posicaoInicial + velocidade * tempo;}

    
    public double CalcularPosicaoMRUV(int posicaoInicial, int velocidade, double tempo, double aceleracao){
        return posicaoInicial + velocidade * tempo + (aceleracao * (tempo * tempo)) / 2.0;}
}

class Program
{
    static void Main(string[] args) {
        Carro carro = new Carro();  
        
    Console.WriteLine(carro.CalcularPosicaoMRU(0, 30, 5));
    Console.WriteLine(carro.CalcularPosicaoMRUV(0, 30, 5, 2.0));
     

    }
}
