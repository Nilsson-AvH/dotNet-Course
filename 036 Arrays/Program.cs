// See https://aka.ms/new-console-template for more information
using System;
namespace Arrays
{
    class Program
    {
        // CONSTRUCTOR Objects

        // ATTRIBS Class fields
        
        // Setter and Getter Methods

        // Methods

        // Main Method
        static void Main(String[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] edades;
            edades = new int[4];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;

            int[] edades1 = { 15, 27, 19, 80 };

            int[] edades2 = new int[5] { 15, 27, 19, 80, 21 };

            Console.WriteLine(edades[2]);
            Console.WriteLine(edades1[2]);
            Console.WriteLine(edades2[2]);

        }
    }
}

