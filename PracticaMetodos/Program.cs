// See https://aka.ms/new-console-template for more information

using System;

namespace PracticaMetodos
{
    class Program
    {
        /*
        static void mensajePantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajePantalla");
        }
        static void Main(string[] args)
        {
            mensajePantalla();
            Console.WriteLine("Mensaje desde el main");
        }
        */

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}");
        }

        static void Main(String[] args)
        {
            sumaNumeros(7, 9);
        }
    }
}
