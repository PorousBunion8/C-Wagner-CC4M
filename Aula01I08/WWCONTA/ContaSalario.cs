using System;

public class ContaSalario : IConta
{
    public void Ativar()
    {
        Console.WriteLine("Conta Salário ativada.");
    }

    public void Sacar(double valor)
    {
        Console.WriteLine("Sacando " + valor + " da Conta Salário.");
    }

    public void Depositar(double valor)
    {
        Console.WriteLine("Depositando " + valor + " na Conta Salário.");
    }

    public void Transferir(IConta contaDestino, double valor)
    {
        Console.WriteLine("Transferindo " + valor + " para a Conta Destino.");
    }

    public void FazerPix(string chave, double valor)
    {
        Console.WriteLine("Fazer Pix não é permitido na Conta Salário.");
    }

    public void Render()
    {
        Console.WriteLine("Conta Salário não rende.");
    }
}
