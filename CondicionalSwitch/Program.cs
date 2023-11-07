// See https://aka.ms/new-console-template for more information
using System;

namespace CondicionalSwitch
{
    class Program
    {
        // All methods


        //Main method
        static void Main (string[] args)
        {

            Console.WriteLine("Escoje un numero de mes para calcular la comisión:");

            int numeroMes = Int32.Parse( Console.ReadLine() );

            switch (numeroMes)
            {
                case 1:
                    Console.WriteLine("Mes escojido. Enero");
                    break;

                case 2:
                    Console.WriteLine("Mes escojido. Febrero");
                    break;

                case 3:
                    Console.WriteLine("Mes escojido. Marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes escojido. Abril");
                    break;

                case 5:
                    Console.WriteLine("Mes escojido. Mayo");
                    break;

                case 6:
                    Console.WriteLine("Mes escojido. Junio");
                    break;

                case 7:
                    Console.WriteLine("Mes escojido. Julio");
                    break;

                case 8:
                    Console.WriteLine("Mes escojido. Agosto");
                    break;

                case 9:
                    Console.WriteLine("Mes escojido. Septiembre");
                    break;

                case 10:
                    Console.WriteLine("Mes escojido. Octubre");
                    break;

                case 11:
                    Console.WriteLine("Mes escojido. Noviembre");
                    break;

                case 12:
                    Console.WriteLine("Mes escojido. Diciembre");
                    break;

                default:
                    Console.WriteLine("Mes invalido");
                    break;

            //Console.WriteLine("Hello, world");

            /*
            Console.WriteLine("Elige medio de transporte (coche, tren, avion)");

            string medioTransporte = Console.ReadLine();

            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("Velocidad media 100k/h");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media 250 k/h");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media 800 k/h");
                    break;

                default:
                    Console.WriteLine("Transporte no contemplado");
                    break;
            */

            }
            Console.WriteLine("Ha terminado el programa.");
        }
    }
}