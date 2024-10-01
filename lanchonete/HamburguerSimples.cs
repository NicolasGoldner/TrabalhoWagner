using System;

public class HamburguerSimples : IHamburguer
{
  public string Descricao 
  {
    get { return "Hamburguer Simples"; }
  }
  public double Custo()
  {
    return 7.00;
  } 
}