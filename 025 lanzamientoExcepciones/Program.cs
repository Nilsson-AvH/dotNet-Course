// See https://aka.ms/new-console-template for more information
using System;

namespace lanzamientoExcepciones
{
    class Program
    {
        public static string nombreDelMes(int mes)
        {
            switch (mes)
            {
                case 1:
                    return "January";

                case 2:
                    return "February";

                case 3:
                    return "March";

                case 4:
                    return "April";

                case 5:
                    return "May";

                case 6:
                    return "June";

                case 7:
                    return "July";

                case 8:
                    return "August";

                case 9:
                    return "September";

                case 10:
                    return "October";

                case 11:
                    return "November";

                case 12:
                    return "December";

                default:

                    throw new ArgumentOutOfRangeException();

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input month number:");

            int numeroMes = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(nombreDelMes(numeroMes));
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Exception message: " + ex.Message);
            }

            Console.WriteLine("Here the program execution continue.");

        }
    }
}