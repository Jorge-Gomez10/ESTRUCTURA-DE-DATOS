using System;
using System.Collections.Generic;

namespace BibliotecaEscolar
{
    // Clase Libro que contiene la información de cada libro
    class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }

        public Libro(string isbn, string titulo, string autor, int añoPublicacion)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
        }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Año de Publicación: {AñoPublicacion}, ISBN: {ISBN}";
        }
    }

    class Program
    {
        // Diccionario para almacenar libros con el ISBN como clave
        static Dictionary<string, Libro> biblioteca = new Dictionary<string, Libro>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("=== Menú Biblioteca Escolar ===");
                Console.WriteLine("1. Registrar un libro");
                Console.WriteLine("2. Buscar un libro por ISBN");
                Console.WriteLine("3. Mostrar todos los libros");
                Console.WriteLine("4. Eliminar un libro por ISBN");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarLibro();
                        break;
                    case 2:
                        BuscarLibro();
                        break;
                    case 3:
                        MostrarLibros();
                        break;
                    case 4:
                        EliminarLibro();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 5);
        }

        // Método para registrar un libro
        static void RegistrarLibro()
        {
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            if (biblioteca.ContainsKey(isbn))
            {
                Console.WriteLine("Ya existe un libro con ese ISBN.");
                return;
            }

            Console.Write("Ingrese el título del libro: ");
            string titulo = Console.ReadLine();

            Console.Write("Ingrese el autor del libro: ");
            string autor = Console.ReadLine();

            Console.Write("Ingrese el año de publicación: ");
            int añoPublicacion = int.Parse(Console.ReadLine());

            // Crear un nuevo libro y agregarlo al diccionario
            Libro nuevoLibro = new Libro(isbn, titulo, autor, añoPublicacion);
            biblioteca[isbn] = nuevoLibro;

            Console.WriteLine("Libro registrado exitosamente.");
        }

        // Método para buscar un libro por ISBN
        static void BuscarLibro()
        {
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            if (biblioteca.ContainsKey(isbn))
            {
                Console.WriteLine("Libro encontrado:");
                Console.WriteLine(biblioteca[isbn]);
            }
            else
            {
                Console.WriteLine("No se encontró un libro con ese ISBN.");
            }
        }

        // Método para mostrar todos los libros
        static void MostrarLibros()
        {
            if (biblioteca.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
                return;
            }

            Console.WriteLine("Libros registrados en la biblioteca:");
            foreach (var libro in biblioteca.Values)
            {
                Console.WriteLine(libro);
            }
        }

        // Método para eliminar un libro por ISBN
        static void EliminarLibro()
        {
            Console.Write("Ingrese el ISBN del libro a eliminar: ");
            string isbn = Console.ReadLine();

            if (biblioteca.Remove(isbn))
            {
                Console.WriteLine("Libro eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("No se encontró un libro con ese ISBN.");
            }
        }
    }
}
