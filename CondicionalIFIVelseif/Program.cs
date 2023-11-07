// See https://aka.ms/new-console-template for more information
using System;

namespace CondicionaIFIVelseif
{
    class Program
    {

        // All methods


        // Main method
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Console.WriteLine("Introduce tu edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres un niño.");

            else if (edad < 30) Console.WriteLine("Eres un joven.");

            else if (edad < 60) Console.WriteLine("Eres maduro.");

            else Console.WriteLine("Eres un viejo, cuidate mucho.");
        }
    }
}
