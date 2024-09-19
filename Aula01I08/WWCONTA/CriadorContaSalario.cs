using System;

public class CriadorContaSalario : CriadoraDeContas
{
    public override IConta CriarConta()
    {
        return new ContaSalario();
    }
}
