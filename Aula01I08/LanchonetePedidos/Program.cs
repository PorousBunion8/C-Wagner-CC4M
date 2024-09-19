using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        IHamburger hamburgerSimples = new HamburgerSimples();
        Console.WriteLine(hamburgerSimples.Descricao() + " custa " + hamburgerSimples.Custo() + " Reais ");

        
        IHamburger hamburgerComBacon = new BaconDecorator(hamburgerSimples);
        Console.WriteLine(hamburgerComBacon.Descricao() + " custa " + hamburgerComBacon.Custo() + " Reais ");

       
        IHamburger hamburgerComAlface = new AlfaceDecorator(hamburgerComBacon);
        Console.WriteLine(hamburgerComAlface.Descricao() + " custa " + hamburgerComAlface.Custo() + " Reais ");

       
        IHamburger hamburgerComQueijo = new QueijoDecorator(hamburgerComAlface);
        Console.WriteLine(hamburgerComQueijo.Descricao() + " custa " + hamburgerComQueijo.Custo() + " Reais ");

      
        IHamburger hamburgerComOvo = new OvoDecorator(hamburgerComQueijo);
        Console.WriteLine(hamburgerComOvo.Descricao() + " custa " + hamburgerComOvo.Custo() + " Reais ");
    }
}
