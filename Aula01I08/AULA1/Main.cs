using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address address = new Address("Avenida Paulista", "123", "Centro", "São Paulo", "SP", "01311-000");
        Person person = new Person("John", "Doe", "john.doe@example.com", address);

      try{
        person.Age = -35;
         person.Print();
      }catch(Exception negativa){
        Console.WriteLine(negativa.Message);
      }
      
     
    }
}


