using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Mail { get; set; }
    public Address Address { get; set; }
    public int _age;
    public int Age { 
        get { return _age; }
        set {
            if (value < 0) {
               throw new Exception("IDADE NAO PODE SER NEGATIVA");
           }
            _age = value;
        }
    }

    

    public Person(string firstName, string lastName, string mail, Address address)
    {
        FirstName = firstName;
        LastName = lastName;
        Mail = mail;
        Address = address;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Mail: {Mail}");
        Address.Print();
      Console.WriteLine($"Age: {Age}");
    }
}
