// See https://aka.ms/new-console-template for more information
using System;

namespace PracticaMetodosII
{
    class Program
    {
        /*
        static int sumaNumeros(int num1, int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(7, 9));
        }
        */
        static double divideNumeros(double num1, double num2) => num1 / num2;
        /*
        {
            return num1 / num2;
        }
        */

        static void Main(string[] args)
        {
            Console.WriteLine(divideNumeros(4, 2));
        }
    }
    
}

