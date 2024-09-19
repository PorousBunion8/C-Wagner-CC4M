using System;

public class OvoDecorator : HamburgerDecorator
{
    public OvoDecorator(IHamburger hamburger) : base(hamburger) { }

    public override string Descricao()
    {
        return _HamburgerDecorado.Descricao() + " + Ovo";
    }

    public override double Custo()
    {
        return _HamburgerDecorado.Custo() + 1000.50; 
    }
}