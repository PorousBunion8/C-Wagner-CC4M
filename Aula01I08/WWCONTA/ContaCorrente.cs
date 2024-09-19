using System;

public class ContaCorrente : IConta
{
    public void Ativar()
    {
        Console.WriteLine("Conta Corrente ativada.");
    }

    public void Sacar(double valor)
    {
        Console.WriteLine("Sacando " + valor + " da Conta Corrente.");
    }

    public void Depositar(double valor)
    {
        Console.WriteLine("Depositando " + valor + " na Conta Corrente.");
    }

    public void Transferir(IConta contaDestino, double valor)
    {
        Console.WriteLine("Transferindo " + valor + " para a Conta Destino.");
    }

    public void FazerPix(string chave, double valor)
    {
        Console.WriteLine("Fazendo Pix de " + valor + " para " + chave + ".");
    }

    public void Render()
    {
        Console.WriteLine("Conta Corrente não rende.");
    }
}
