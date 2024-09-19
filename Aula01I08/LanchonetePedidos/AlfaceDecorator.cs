using System;

public class AlfaceDecorator : HamburgerDecorator
{
    public AlfaceDecorator(IHamburger hamburger) : base(hamburger) { }

    public override string Descricao()
    {
        return _HamburgerDecorado.Descricao() + " + Alface";
    }

    public override double Custo()
    {
        return _HamburgerDecorado.Custo() + 0.50; 
    }
}