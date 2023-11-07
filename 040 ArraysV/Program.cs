// See https://aka.ms/new-console-template for more information
using System;

namespace ArraysV
{
    class Program
    {
        // Constructor Objects

        // Attribs class fields

        // Getter and Setter methods

        // Methods
        static void ProcesaDatos(int[] datos)
        {
            /*
            foreach(int i in datos) 
            { 
                Console.WriteLine(i);
            }
            */
            for (int i = 0;i < datos.Length; i++) 
            {
                datos[i] += 10;
            }
        }

        // Main method
        static void Main(string[] args)
        {
            int[] numeros= new int[4];
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;

            ProcesaDatos(numeros);

            foreach (int i in numeros) 
            { 
                Console.WriteLine(i);
            }

        }
    }
}
