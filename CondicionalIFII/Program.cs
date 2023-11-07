// See https://aka.ms/new-console-template for more information
using System;

namespace CondicionalIFII
{
    class Program
    {

        //All methods

        //Maind method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("Digite su edad:");
            int edad = Int32.Parse(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Lo siento, eres menor de edad, no puedes conducir un vehiculo.");
            else
            {
                Console.WriteLine("Tienes carnet?");
                string carnet = Console.ReadLine();
                int compara = String.Compare(carnet, "si", true);
                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos.");
                else Console.WriteLine("A pesar de que eres mayor de edad no tienes carnet, no puedes conducir un vehiculo");
            }
        }
    }
}

