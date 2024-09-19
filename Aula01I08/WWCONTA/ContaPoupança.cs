using System;

public class ContaPoupanca : IConta
{
    private const int LIMITE_SAQUES = 3;
    private int saquesRealizados = 0;
    private double saldo = 0;

    public void Ativar()
    {
        Console.WriteLine("Conta Poupança ativada.");
    }

    public void Sacar(double valor)
    {
        if (saquesRealizados < LIMITE_SAQUES)
        {
            saldo -= valor;
            saquesRealizados++;
            Console.WriteLine("Sacando " + valor + " da Conta Poupança.");
        }
        else
        {
            saldo -= (valor + 1.00); 
            Console.WriteLine("Sacando " + valor + " da Conta Poupança com taxa de R$1,00.");
        }
    }

    public void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine("Depositando " + valor + " na Conta Poupança.");
    }

    public void Transferir(IConta contaDestino, double valor)
    {
        if (contaDestino is ContaCorrente)
        {
            saldo -= valor;
            Console.WriteLine("Transferindo " + valor + " para a Conta Corrente.");
        }
        else
        {
            Console.WriteLine("Transferência permitida apenas para Conta Corrente.");
        }
    }

    public void FazerPix(string chave, double valor)
    {
        Console.WriteLine("Fazer Pix não é permitido na Conta Poupança.");
    }

    public void Render()
    {
        Console.WriteLine("Conta Poupança rendendo.");
    }
}
