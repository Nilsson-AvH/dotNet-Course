// See https://aka.ms/new-console-template for more information
using _035_ClasesAnonimas;
using System;
// using static System.Math;

namespace ClasesAnonimas
{ 
    class Program
    {
        // Constructor Objects

        // Attributes Campos de CLase

        // Setter and Getter Methods

        // Methods
        static void realizarTarea()
        {
            // TODO: 
            Punto origen = new Punto();
            Punto destino = new Punto(150, 90);
            Punto otropunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Número de objetos creados: {Punto.getContadorDeObjetos()}");
        }

        // Main Method
        static void Main(string[] args) 
        {
            // Clases anonimas

            var miVariable = new { Nombre = "Nilson", Edad = 19 };
            Console.WriteLine($"Su nombre es {miVariable.Nombre} y su edad es {miVariable.Edad}.");

            var miOtraVariable = new { Nombre = "Kathe", Edad = 18 };
            miVariable = miOtraVariable;

            // Console.WriteLine("Hello, World!");
            // realizarTarea();
            /* double raiz = Math.Sqrt(9);
            double potencia = Math.Pow(3, 4);
            Console.WriteLine($"La raiz cuadrada es: {raiz} y la potencia es: {potencia}"); */
        }
    }
}