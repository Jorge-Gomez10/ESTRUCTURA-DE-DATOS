using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Crear conjunto ficticio de 500 ciudadanos
        var totalCiudadanos = new HashSet<int>(Enumerable.Range(1, 500));
        
        // Crear conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        var vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));
        
        // Crear conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        var vacunadosAstraZeneca = new HashSet<int>(Enumerable.Range(51, 75));
        
        // Para asegurar que algunos ciudadanos han recibido ambas vacunas
        var vacunadosAmbas = new HashSet<int>(Enumerable.Range(101, 25));

        // Actualizar los conjuntos de vacunados con ambas vacunas
        vacunadosPfizer.UnionWith(vacunadosAmbas);
        vacunadosAstraZeneca.UnionWith(vacunadosAmbas);

        // Listado de ciudadanos que no se han vacunado
        var noVacunados = new HashSet<int>(totalCiudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);
        
        // Listado de ciudadanos que han recibido las dos vacunas
        var vacunadosDosVeces = new HashSet<int>(vacunadosPfizer);
        vacunadosDosVeces.IntersectWith(vacunadosAstraZeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        var soloPfizer = new HashSet<int>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosDosVeces);
        
        // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
        var soloAstraZeneca = new HashSet<int>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosDosVeces);

        // Imprimir resultados
        Console.WriteLine("Listado de ciudadanos que no se han vacunado:");
        ImprimirListado(noVacunados);

        Console.WriteLine("\nListado de ciudadanos que han recibido las dos vacunas:");
        ImprimirListado(vacunadosDosVeces);

        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de Pfizer:");
        ImprimirListado(soloPfizer);

        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de AstraZeneca:");
        ImprimirListado(soloAstraZeneca);
    }

    static void ImprimirListado(HashSet<int> listado)
    {
        foreach (var ciudadano in listado)
        {
            Console.Write(ciudadano + " ");
        }
        Console.WriteLine();
    }
}
