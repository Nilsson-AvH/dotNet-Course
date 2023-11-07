// See https://aka.ms/new-console-template for more information
using System;

namespace PracticaMetodos5
{
    class Program
    {

        //All methods
        private static double suma(int num1, double num2, double num3=0)
        {
            return num1 + num2 + num3;
        }
        private static double suma(int num1, double num2)
        {
            return num1 + num2;
        }

        //Main method
        static void Main (string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(suma(valor1, valor2));
            //Console.WriteLine(suma(valor1, valor2, valor3));
        }                
    }
}