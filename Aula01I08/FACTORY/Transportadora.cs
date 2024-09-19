public abstract class Transportadora{
  
  public abstract ITransporte CriarTransporte();

  public void RealizarEntrega(){
    ITransporte transporte = CriarTransporte();
    transporte.Entregar();
  }
}