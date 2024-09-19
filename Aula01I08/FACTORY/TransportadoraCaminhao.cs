//creator concreto para caminhao
public class TransportadoraCaminhao : Transportadora{

public override ITransporte criarTransporte(){
  return new Caminhao();
}
}