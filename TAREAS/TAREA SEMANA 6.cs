//Función que calcule el número de elementos de una lista:La idea de este algoritmo es bastante sencilla, lo que tendremos q hacer para ver la longitud de una lista es simplemente recorrer la lista hasta el final e ir contando el número de saltos. El principal motivo por el que deberíamos implementar es que nos es que nos permite aprender y comprender permite aprender y comprender el manejo de los nodos.

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

            int numeroDeElementos = lista.ContarElementos();
            Console.WriteLine("El número de elementos en la lista es: " + numeroDeElementos);
        }
    }
}
