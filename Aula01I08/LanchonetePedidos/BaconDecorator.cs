using System;

public class BaconDecorator : HamburgerDecorator
{
    public BaconDecorator(IHamburger hamburger) : base(hamburger) { }

    public override string Descricao()
    {
        return _HamburgerDecorado.Descricao() + " + Bacon";
    }

    public override double Custo()
    {
        return _HamburgerDecorado.Custo() + 400.50; 
    }
}