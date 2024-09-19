using System;
using System.Collections.Generic;

public class Station : ISubject
{
    private List<IObserver> _observers;
    private float _temperature;
    private string _uf;

    public Station(string uf)
    {
        _observers = new List<IObserver>();
        _uf = uf;
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_temperature, _uf);
        }
    }

    public void SetTemperature(float temperature)
    {
        _temperature = temperature;
        NotifyObservers();
    }

    public string UF
    {
        get => _uf;
        set => _uf = value;
    }
}
