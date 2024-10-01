using System;
using System.Collections.Generic;

public class Pedido: ISujeito
{
  public List<IObserver> _observadores = new List<IObserver>();
  public IHamburguer _hamburguer;
  public string _status;

  public Pedido(IHamburguer hamburguer)
  {
    _hamburguer = hamburguer;
  }

  public string Descricao
  {
    get
    {
      return _hamburguer.Descricao;
    }
  }

  public double Custo
  {
    get { return _hamburguer.Custo(); }
  }

  public string Status
  {
    get { return _status; }
    set { _status = value; NotificarObservadores();}
  }

  public void AdicionarObservador(IObserver observador)
  {
      _observadores.Add(observador);
  }

  public void RemoverObservador(IObserver observador)
  {
      _observadores.Remove(observador);
  }

  public void NotificarObservadores()
  {
      foreach (var observador in _observadores)
      {
          observador.Atualizar(this);
      }
  }

  
}