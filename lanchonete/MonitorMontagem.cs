using System;
public class MonitorMontagem : IObserver
{
    public void Atualizar(Pedido pedido)
    {
        Console.WriteLine($"Montagem notificada: Organizar {pedido.Descricao}. Status: {pedido.Status}");
    }
}