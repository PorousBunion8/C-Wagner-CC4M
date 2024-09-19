using System;
using PolymorphismSample;

class Program
{
    static void Main(string[] args)
    {

///////////////////////FIGURAS2D//////////////////////////
        
        Quadrado quadrado = new Quadrado(4);
        Console.WriteLine("Quadrado:");
        Console.WriteLine("Perímetro: " + quadrado.CalcularPerimetro());
        Console.WriteLine("Área: " + quadrado.CalcularArea());

        Retangulo retangulo = new Retangulo(4, 6);
        Console.WriteLine("\nRetângulo:");
        Console.WriteLine("Perímetro: " + retangulo.CalcularPerimetro());
        Console.WriteLine("Área: " + retangulo.CalcularArea());

        Triangulo triangulo = new Triangulo(3, 4, 5);
        Console.WriteLine("\nTriângulo:");
        Console.WriteLine("Perímetro: " + triangulo.CalcularPerimetro());
        Console.WriteLine("Área: " + triangulo.CalcularArea());

        Circulo circulo = new Circulo(3);
        Console.WriteLine("\nCírculo:");
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());
        Console.WriteLine("Área: " + circulo.CalcularArea());

///////////////////////FIGURAS3D//////////////////////////

        
        Cubo cubo = new Cubo(5);
        Console.WriteLine("\nCubo:");
        Console.WriteLine("Perímetro: " + cubo.CalcularPerimetro());
        Console.WriteLine("Área: " + cubo.CalcularArea());
        Console.WriteLine("Volume: " + cubo.CalcularVolume());

        Esfera esfera = new Esfera(3);
        Console.WriteLine("\nEsfera:");
        Console.WriteLine("Área: " + esfera.CalcularArea());
        Console.WriteLine("Volume: " + esfera.CalcularVolume());

        Cilindro cilindro = new Cilindro(4, 7);
        Console.WriteLine("\nCilindro:");
        Console.WriteLine("Perímetro da base: " + cilindro.CalcularPerimetro());
        Console.WriteLine("Área: " + cilindro.CalcularArea());
        Console.WriteLine("Volume: " + cilindro.CalcularVolume());

        Cone cone = new Cone(3, 6);
        Console.WriteLine("\nCone:");
        Console.WriteLine("Área: " + cone.CalcularArea());
        Console.WriteLine("Volume: " + cone.CalcularVolume());
    }
}

