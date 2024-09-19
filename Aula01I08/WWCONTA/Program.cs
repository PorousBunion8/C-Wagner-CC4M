

using System;

public class Program
{
    public static void Main(string[] args)
    {
       
        ContaPoupanca contaPoupanca = new ContaPoupanca();
        ContaSalario contaSalario = new ContaSalario();
        ContaCorrente contaCorrente = new ContaCorrente();

      
        Console.WriteLine("==== Teste: Conta Poupança ====");
        contaPoupanca.Ativar();
        contaPoupanca.Depositar(500);
        contaPoupanca.Sacar(100);
        contaPoupanca.Sacar(50);
        contaPoupanca.Sacar(75); 
        contaPoupanca.Sacar(30); 
        contaPoupanca.Render();  

        
        Console.WriteLine("\n==== Teste: Conta Salário ====");
        contaSalario.Ativar();
        contaSalario.Depositar(1000);
        contaSalario.Sacar(300);
        contaSalario.Transferir(contaCorrente, 200);  
        contaSalario.FazerPix("chave-salario", 50);  
        contaSalario.Render();  

       
        Console.WriteLine("\n==== Teste: Conta Corrente ====");
        contaCorrente.Ativar();
        contaCorrente.Depositar(1500);
        contaCorrente.Sacar(400);
        contaCorrente.Transferir(contaPoupanca, 200); 
        contaCorrente.FazerPix("chave-corrente", 100); 
        contaCorrente.Render();  
    }
}