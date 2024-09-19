using System;
public abstract class HamburgerDecorator : IHamburger
{
  protected IHamburger _HamburgerDecorado;

  public HamburgerDecorator(IHamburger Hamburger)
  {
    _HamburgerDecorado = Hamburger;
  }

  public virtual string Descricao()
  {
    return _HamburgerDecorado.Descricao();
  }

  public virtual double Custo()
  {
    return _HamburgerDecorado.Custo();
  }
}