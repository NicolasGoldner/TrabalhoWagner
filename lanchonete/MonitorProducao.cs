using System;

public class MonitorProducao : IObserver
{
    public void Atualizar(Pedido pedido)
    {
        Console.WriteLine($"Produção notificada: Preparar {pedido.Descricao}. Status: {pedido.Status}");
    }
}