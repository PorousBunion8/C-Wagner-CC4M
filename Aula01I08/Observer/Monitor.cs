using System;

public class Monitor : IObserver
{
    private string _name;

    public Monitor(string name)
    {
        _name = name;
    }

    public void Update(float temperature, string uf)
    {
        Console.WriteLine($"Monitor {_name}: Temperatura atual em {uf} é {temperature}°C.");
    }
}
