using System;
public class LeiteDecorator : CafeDecorator
{
  public LeiteDecorator(ICafe cafe) : base(cafe)
  {
    
  }

  public override string Descricao()
  {
    return _cafeDecorado.Descricao() + " + Leite";
  }

  public override double Custo(){
    return base.Custo() + 1.0;
  }
}