using System;
using System.Collections.Generic;

class Traductor
{
    // Diccionarios para traducción de español a inglés y viceversa
    static Dictionary<string, string> espanolIngles = new Dictionary<string, string>()
    {
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"gobierno", "government"},
        {"empresa", "company"}
    };

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            // Menú de opciones
            Console.WriteLine("\nMENU");
            Console.WriteLine("==========================");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TraducirFrase();
                    break;
                case 2:
                    AgregarPalabra();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa.");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (opcion != 0);
    }

    static void TraducirFrase()
    {
        Console.Write("Ingrese la frase en español: ");
        string frase = Console.ReadLine().ToLower();
        string[] palabras = frase.Split(' ');

        List<string> traduccion = new List<string>();

        foreach (string palabra in palabras)
        {
            if (espanolIngles.ContainsKey(palabra))
            {
                traduccion.Add(espanolIngles[palabra]);
            }
            else
            {
                traduccion.Add(palabra);
            }
        }

        Console.WriteLine("Su frase traducida es: " + string.Join(" ", traduccion));
    }

    static void AgregarPalabra()
    {
        Console.Write("Ingrese la palabra en español: ");
        string espanol = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en inglés: ");
        string ingles = Console.ReadLine().ToLower();

        if (!espanolIngles.ContainsKey(espanol))
        {
            espanolIngles.Add(espanol, ingles);
            Console.WriteLine("Palabra agregada con éxito.");
        }
        else
        {
            Console.WriteLine("La palabra ya existe en el diccionario.");
        }
    }
}
