using System;
using System.Collections.Generic;

public interface ISujeito
{
    void AdicionarObservador(IObserver observador);
    void RemoverObservador(IObserver observador);
    void NotificarObservadores();
}