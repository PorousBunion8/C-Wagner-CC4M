using System;

public interface IConta
{
    void Ativar();
    void Sacar(double valor);
    void Depositar(double valor);
    void Transferir(IConta contaDestino, double valor);
    void FazerPix(string chave, double valor);
    void Render(); 
}