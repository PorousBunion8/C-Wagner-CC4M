using System;
using System.Collections.Generic;

class Program
{
    static List<Station> stations = new List<Station>();
    static List<Monitor> monitors = new List<Monitor>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Criar Nova Estação");
            Console.WriteLine("2 - Atualizar Estação");
            Console.WriteLine("3 - Remover Estação");
            Console.WriteLine("4 - Criar Monitor");
            Console.WriteLine("5 - Editar Monitor");

            var option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    running = false;
                    break;

                case "1":
                    CreateNewStation();
                    break;

                case "2":
                    UpdateStation();
                    break;

                case "3":
                    RemoveStation();
                    break;

                case "4":
                    CreateMonitor();
                    break;

                case "5":
                    EditMonitor();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    static void CreateNewStation()
    {
        Console.Write("Digite a UF da nova estação: ");
        var uf = Console.ReadLine();
        var station = new Station(uf);
        stations.Add(station);
        Console.WriteLine("Nova estação criada.");
    }

    static void UpdateStation()
    {
        Console.Write("Digite o índice da estação para atualizar: ");
        var index = int.Parse(Console.ReadLine());
        if (index < 0 || index >= stations.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }

        var station = stations[index];
        Console.Write("Digite a nova temperatura: ");
        station.SetTemperature(float.Parse(Console.ReadLine()));

        Console.WriteLine("Temperatura atualizada.");
    }

    static void RemoveStation()
    {
        Console.Write("Digite o índice da estação para remover: ");
        var index = int.Parse(Console.ReadLine());
        if (index < 0 || index >= stations.Count)
        {
            Console.WriteLine("Índice inválido.");
            return;
        }

        stations.RemoveAt(index);
        Console.WriteLine("Estação removida.");
    }

    static void CreateMonitor()
    {
        Console.Write("Digite o nome do monitor: ");
        var name = Console.ReadLine();
        var monitor = new Monitor(name);
        monitors.Add(monitor);
        Console.WriteLine("Monitor criado.");

        // Lógica para associar o monitor a uma estação pode ser implementada aqui.
    }

    static void EditMonitor()
    {
        Console.Write("Digite o nome do monitor a editar: ");
        var name = Console.ReadLine();
        var monitor = monitors.Find(m => m._name == name);
        if (monitor == null)
        {
            Console.WriteLine("Monitor não encontrado.");
            return;
        }

        // Lógica para adicionar ou remover estações monitoradas pode ser implementada aqui.
        Console.WriteLine("Monitor editado.");
    }
}
