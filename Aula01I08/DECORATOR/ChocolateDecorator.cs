using System;

public class ChocolateDecorator : CafeDecorator
{
    public ChocolateDecorator(ICafe cafe) : base(cafe) // Remove the extra parenthesis here
    {

    }

    public override string Descricao()
    {
        return _cafeDecorado.Descricao() + " + chocolate";
    }

    public override double Custo()
    {
        return base.Custo() + 2.0;
    }
}
