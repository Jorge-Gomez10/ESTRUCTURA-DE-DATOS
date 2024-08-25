using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Crear el conjunto de 500 ciudadanos participantes
        HashSet<int> participantes = new HashSet<int>(Enumerable.Range(1, 500));

        // Crear el conjunto de 75 ciudadanos vacunados con Pfizer
        HashSet<int> vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));

        // Crear el conjunto de 75 ciudadanos vacunados con AstraZeneca
        HashSet<int> vacunadosAstraZeneca = new HashSet<int>(Enumerable.Range(76, 75));

        // Ciudadanos que han recibido ambas vacunas 
        HashSet<int> vacunadosAmbas = new HashSet<int>();

        // Ciudadanos que no se han vacunado
        HashSet<int> noVacunados = new HashSet<int>(participantes);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que han recibido ambas vacunas (vacíos en este ejemplo)
        HashSet<int> vacunadosConAmbas = new HashSet<int>(vacunadosPfizer);
        vacunadosConAmbas.IntersectWith(vacunadosAstraZeneca);

        // Ciudadanos que han recibido solo la vacuna de Pfizer
        HashSet<int> soloPfizer = new HashSet<int>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstraZeneca);

        // Ciudadanos que han recibido solo la vacuna de AstraZeneca
        HashSet<int> soloAstraZeneca = new HashSet<int>(vacunadosAstraZeneca);
        soloAstraZeneca.ExceptWith(vacunadosPfizer);

        // Imprimir resultados
        Console.WriteLine("Listado de ciudadanos que no se han vacunado:");
        foreach (var participante in noVacunados)
        {
            Console.WriteLine("Participante #" + participante);
        }

        Console.WriteLine("\nListado de ciudadanos que han recibido ambas vacunas:");
        foreach (var participante in vacunadosConAmbas)
        {
            Console.WriteLine("Participante #" + participante);
        }

        Console.WriteLine("\nListado de ciudadanos que solo han recibido la vacuna de Pfizer:");
        foreach (var participante in soloPfizer)
        {
            Console.WriteLine("Participante #" + participante);
        }

        Console.WriteLine("\nListado de ciudadanos que solo han recibido la vacuna de AstraZeneca:");
        foreach (var participante in soloAstraZeneca)
        {
            Console.WriteLine("Participante #" + participante);
        }
    }
}
