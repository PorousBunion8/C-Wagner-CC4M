using System;

public class CafeSimples : ICafe
{
    public string Descricao()
    {
        return "Café Simples";
    }

    public double Custo() // Fixed 'doule' to 'double'
    {
        return 2.00;
    }
}
