// See https://aka.ms/new-console-template for more information
using System;

namespace usoCheked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            checked // sin el cheked el overflow no apareceria, sel compilador por cuestiones de
                //agilidad el programa no cae y da como resultadoun valor negativo y continua.
            {
                int numero = int.MaxValue;

                int resultado = numero + 20;

                Console.WriteLine(resultado);
            }
        }
    }
}
