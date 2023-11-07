// See https://aka.ms/new-console-template for more information
using _033_CallsAndMath;
using System;

namespace CallsAndMath
{
    class Program
    {
        // CONSTRUCTORS

        // ATTRIBUTES

        // SETTER AND GETTER METHODS 

        // METHODS

        static void realizarTarea()
        {
            // TODO: 
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otropunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Nùmero de objetos creados: {Punto.getContadorDeObjetos()}");
        }

        

        // MAIN METHOD, 
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            realizarTarea();

        }

    }
}