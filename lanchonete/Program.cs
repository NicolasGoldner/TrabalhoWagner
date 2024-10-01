using System;


public class Program
{
    public static void Main(string[] args)
    {

        IHamburguer hamburguer = new HamburguerSimples();
        Console.WriteLine("Bem vindo a lanchonete!");
        Console.WriteLine("O que você deseja?");
        hamburguer = new Bacon(hamburguer);
        hamburguer = new Queijo(hamburguer);
        hamburguer = new Tomate(hamburguer);
        hamburguer = new Pepino(hamburguer);
        hamburguer = new Alface(hamburguer);
     
        Pedido pedido = new Pedido(hamburguer);

      
        MonitorProducao producao = new MonitorProducao();
        MonitorMontagem montagem = new MonitorMontagem();

        pedido.AdicionarObservador(producao);
        pedido.AdicionarObservador(montagem);

       
        pedido.Status = "Em produção";
        pedido.Status = "Pronto para entrega";
        
        
        Console.WriteLine($"Pedido: {pedido.Descricao}, Custo Total: {pedido.Custo:C2}");
    }
}