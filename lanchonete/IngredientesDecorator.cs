using System;

public abstract class IngredientesDecorator : IHamburguer
{
  protected IHamburguer _hamburguer;

  public IngredientesDecorator(IHamburguer hamburguer)
  {
    _hamburguer = hamburguer;
  }

  public abstract string Descricao { get; }

  public abstract double Custo();
}