using System;

public class CheeseDecorator : HamburgerDecorator
{
    public CheeseDecorator(IHamburger hamburger) : base(hamburger) { }

    public override string Descricao()
    {
        return _HamburgerDecorado.Descricao() + " + Queijo";
    }

    public override double Custo()
    {
        return _HamburgerDecorado.Custo() + 1.50; 
    }
}