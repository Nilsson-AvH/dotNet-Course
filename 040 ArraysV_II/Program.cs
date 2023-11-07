// See https://aka.ms/new-console-template for more information
using System;

namespace ArraysV_II
{
    class Program
    {
        // Constructor objects

        // Attrrib class fields

        // Getter and Setter methods

        // Methods
        static int[] LeerDatos()
        {
            Console.WriteLine("¿Cuantos datos quieres que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i = 0;i < numElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posición {i}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                datos[i] = datosElemento;
            }
            return datos;
        }

        // Main Method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("Imprimiendo desde el Main.");
            
            foreach (int i in arrayElementos) Console.WriteLine(i);
        }
    }
}
