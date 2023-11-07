// See https://aka.ms/new-console-template for more information

using System;

namespace bucleWhileI
{
    class Program
    {
        // All Methods


        // Main Method
        static void Main (string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("¿Deseas ingresar en el bucle While?");

            string respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("Estás ejecutando el interior del bucle While");
                Console.WriteLine("Introduce tu nombre, por favor:");

                string nombre = Console.ReadLine();

                Console.WriteLine($"Saldrás del bucle {nombre} cuando respondas 'no' a la pregunta:");

                Console.WriteLine("¿Deseas repetir de nuevo el ciclo While?");

                respuesta = Console.ReadLine();
            }

            Console.WriteLine("Has salido del bucle While.");

        }
    }
}

