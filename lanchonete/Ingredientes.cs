using System;

public class Bacon: IngredientesDecorator
{
  public Bacon(IHamburguer hamburguer): base(hamburguer){}

  public override string Descricao
  {
    get
    {
      return _hamburguer.Descricao + ", Bacon";
    }
  }

  public override double Custo()
  {
    return _hamburguer.Custo() + 1.50;
  }
}

public class Queijo: IngredientesDecorator
{
  public Queijo(IHamburguer hamburguer): base(hamburguer){}

  public override string Descricao
  {
    get
    {
      return _hamburguer.Descricao + ", Queijo";
    }
  }

  public override double Custo()
  {
    return _hamburguer.Custo() + 1.00;
  }
}

public class Tomate: IngredientesDecorator
{
  public Tomate(IHamburguer hamburguer): base(hamburguer){}

  public override string Descricao
  {
    get
    {
      return _hamburguer.Descricao + ", Tomate";
    }
  }

  public override double Custo()
  {
    return _hamburguer.Custo() + 0.40;
  }
}

public class Pepino: IngredientesDecorator
{
  public Pepino(IHamburguer hamburguer): base(hamburguer){}

  public override string Descricao
  {
    get
    {
      return _hamburguer.Descricao + ", Pepino";
    }
  }

  public override double Custo()
  {
    return _hamburguer.Custo() + 0.10;
  }
}

public class Alface: IngredientesDecorator
{
  public Alface(IHamburguer hamburguer): base(hamburguer){}

  public override string Descricao
  {
    get
    {
      return _hamburguer.Descricao + ", Alface";
    }
  }

  public override double Custo()
  {
    return _hamburguer.Custo() + 0.05;
  }
}