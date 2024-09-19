using System;

namespace PolymorphismSample
{
    public abstract class Figura2D : FiguraGeometrica
    {
        public override double CalcularVolume()
        {
            return 0; 
        }
    }

    public class Quadrado : Figura2D
    {
        private double lado;

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        
    }

    public class Retangulo : Figura2D
    {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (largura + altura);
        }

        public override double CalcularArea()
        {
            return largura * altura;
        }

       
    }

    public class Triangulo : Figura2D
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public override double CalcularArea()
        {
            double s = CalcularPerimetro() / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

      
    }

    public class Circulo : Figura2D
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

       
    }
}
