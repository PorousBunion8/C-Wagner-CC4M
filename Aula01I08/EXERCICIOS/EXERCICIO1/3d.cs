using System;

namespace PolymorphismSample
{
    public abstract class Figura3D : FiguraGeometrica
    {
        public override abstract double CalcularVolume();

       
    }

    public class Cubo : Figura3D
    {
        private double aresta;

        public Cubo(double aresta)
        {
            this.aresta = aresta;
        }

        public override double CalcularPerimetro()
        {
            return 12 * aresta;
        }

        public override double CalcularArea()
        {
            return 6 * aresta * aresta;
        }

        public override double CalcularVolume()
        {
            return aresta * aresta * aresta;
        }
    }

    public class Esfera : Figura3D
    {
        private double raio;

        public Esfera(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularPerimetro()
        {
            return 0; 
        }

        public override double CalcularArea()
        {
            return 4 * Math.PI * raio * raio;
        }

        public override double CalcularVolume()
        {
            return (4 / 3.0) * Math.PI * Math.Pow(raio, 3);
        }
    }

    public class Cilindro : Figura3D
    {
        private double raio;
        private double altura;

        public Cilindro(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }

        public override double CalcularArea()
        {
            return 2 * Math.PI * raio * (raio + altura);
        }

        public override double CalcularVolume()
        {
            return Math.PI * raio * raio * altura;
        }
    }

    public class Cone : Figura3D
    {
        private double raio;
        private double altura;

        public Cone(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public override double CalcularPerimetro()
        {
            return 0; 
        }

        public override double CalcularArea()
        {
            double geratriz = Math.Sqrt(raio * raio + altura * altura);
            return Math.PI * raio * (raio + geratriz);
        }

        public override double CalcularVolume()
        {
            return (1 / 3.0) * Math.PI * raio * raio * altura;
        }
    }
}

