using System;

public abstract class CriadoraDeContas
{
    public abstract IConta CriarConta();

    public void AtivarConta()
    {
        IConta conta = CriarConta();
        conta.Ativar();
    }
}
