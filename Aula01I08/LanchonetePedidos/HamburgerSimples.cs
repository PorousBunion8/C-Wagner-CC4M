using System;

public class HamburgerSimples : IHamburger
{
    public string Descricao()
    {
        return "Hamburger Simples";
    }

    public double Custo() 
    {
        return 200.00;
    }
}
