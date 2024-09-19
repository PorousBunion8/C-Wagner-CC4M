using System;

public class Address
{
    public string Avenida { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }

    public Address(string avenida, string numero, string bairro, string cidade, string estado, string cep)
    {
        Avenida = avenida;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
    }

    public void Print()
    {
        Console.WriteLine($"Address: {Avenida}, {Numero}, {Bairro}, {Cidade}, {Estado}, {CEP}");
    }
}
