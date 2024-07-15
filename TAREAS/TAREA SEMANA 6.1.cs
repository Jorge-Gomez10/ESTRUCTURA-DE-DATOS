//Invertir una lista enlazada: Implementar un método dentro de la lista enlazada que permita invertir los datos almacenados en una lista enlazada, es decir que el primer elemento pase a ser el último y el último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el segundo y así sucesivamente.

using System;

namespace ListaEnlazada
{
    // Definición de la clase Nodo
    public class Nodo
    {
        public int Valor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }

    // Definición de la clase ListaEnlazada
    public class ListaEnlazada
    {
        public Nodo Cabeza { get; set; }

        public ListaEnlazada()
        {
            Cabeza = null;
        }

        // Función para agregar un nodo al final de la lista
        public void AgregarNodo(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor);
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
            }
            else
            {
                Nodo nodoActual = Cabeza;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                nodoActual.Siguiente = nuevoNodo;
            }
        }

        // Función para contar el número de elementos en la lista
        public int ContarElementos()
        {
            int contador = 0;
            Nodo nodoActual = Cabeza;
            while (nodoActual != null)
            {
                contador++;
                nodoActual = nodoActual.Siguiente;
            }
            return contador;
        }

        // Función para invertir la lista enlazada
        public void InvertirLista()
        {
            Nodo previo = null;
            Nodo actual = Cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente; // Guardar el siguiente nodo
                actual.Siguiente = previo;    // Invertir el enlace
                previo = actual;              // Mover previo y actual un paso adelante
                actual = siguiente;
            }

            Cabeza = previo; // Actualizar la cabeza para que sea el último nodo procesado
        }

        // Función para imprimir la lista
        public void ImprimirLista()
        {
            Nodo nodoActual = Cabeza;
            while (nodoActual != null)
            {
                Console.Write(nodoActual.Valor + " ");
                nodoActual = nodoActual.Siguiente;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.AgregarNodo(1);
            lista.AgregarNodo(2);
            lista.AgregarNodo(3);
            lista.AgregarNodo(4);

            Console.WriteLine("Lista original:");
            lista.ImprimirLista();

            lista.InvertirLista();

            Console.WriteLine("Lista invertida:");
            lista.ImprimirLista();
        }
    }
}
