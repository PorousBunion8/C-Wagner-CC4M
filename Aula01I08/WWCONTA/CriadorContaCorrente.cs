using System;

public class CriadorContaCorrente : CriadoraDeContas
{
    public override IConta CriarConta()
    {
        return new ContaCorrente();
    }
}
