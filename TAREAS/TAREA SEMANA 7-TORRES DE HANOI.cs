// TORRES DE HANOI

using System;
using System.Collections.Generic;

class Torre
{
    public Stack<int> Discos { get; private set; }
    public string Nombre { get; private set; }

    public Torre(string nombre)
    {
        Discos = new Stack<int>();
        Nombre = nombre;
    }

    public void AgregarDisco(int disco)
    {
        if (Discos.Count > 0 && Discos.Peek() <= disco)
        {
            throw new InvalidOperationException("No se puede colocar un disco más grande sobre uno más pequeño");
        }
        Discos.Push(disco);
    }

    public void MoverDiscoHacia(Torre destino)
    {
        if (Discos.Count == 0)
        {
            throw new InvalidOperationException("No hay discos para mover");
        }
        destino.AgregarDisco(Discos.Pop());
        Console.WriteLine($"Mover disco de {Nombre} a {destino.Nombre}");
    }
}

class Program
{
    static void MoverDiscos(int n, Torre origen, Torre destino, Torre auxiliar)
    {
        if (n > 0)
        {
            MoverDiscos(n - 1, origen, auxiliar, destino);
            origen.MoverDiscoHacia(destino);
            MoverDiscos(n - 1, auxiliar, destino, origen);
        }
    }

    static void Main(string[] args)
    {
        int numDiscos = 3;

        Torre torreA = new Torre("Torre A");
        Torre torreB = new Torre("Torre B");
        Torre torreC = new Torre("Torre C");

        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.AgregarDisco(i);
        }

        MoverDiscos(numDiscos, torreA, torreC, torreB);
    }
}
