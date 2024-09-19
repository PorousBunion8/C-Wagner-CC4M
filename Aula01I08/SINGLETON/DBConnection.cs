using System;

public class DBConnection{

  private static DBConnection instance;

  private DBConnection(){
    Console.WriteLine("Nova conexão de banco foi criada.");
  }

  public static DBConnection Instance{
    get{
      if(instance == null){
        instance = new DBConnection();
      }
      return instance;
    }
  }




  public void ExecuteCommand(string sql){
    Console.WriteLine("Executando comando: " + sql);
  }
}


public class Program{
  public static void Main(){
    DBConnection c1 = DBConnection.Instance;
    c1.ExecuteCommand("SELECT * FROM xpto");
  }
}