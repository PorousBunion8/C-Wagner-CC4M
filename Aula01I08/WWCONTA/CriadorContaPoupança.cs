using System;

public class CriadorContaPoupanca : CriadoraDeContas
{
    public override IConta CriarConta()
    {
        return new ContaPoupanca();
    }
}
