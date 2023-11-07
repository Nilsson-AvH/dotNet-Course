// See https://aka.ms/new-console-template for more information

using System;
namespace doWhile
{
    class Program
    {
        //All Methods

        //Main Method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Console.WriteLine("-------- PROGRAMA ADIVINÁ EL NUMERO ----------");
            Console.WriteLine("");
            Console.WriteLine("Generando número aleatorio entre 1 y 100.");
            Console.WriteLine("Número generado y guadado en la memoria principal.");
            Console.WriteLine("");

            //Generar numero aleatorio
            Random number = new Random();
            int randomNumber = number.Next(0, 100);
            Console.WriteLine($"El número aleatorio es {randomNumber} eeexito.");
            //FIN generar numero aleatorio

            Console.WriteLine("Adiviná el numero y digitalo:");
            int guessedNumber = Int32.Parse(Console.ReadLine());
            int cont = 1;

            while (randomNumber != guessedNumber)
            {
                cont++;
                Console.WriteLine("");
                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine($"  >>  El número a adivinar es más GRANDE que {guessedNumber}.");
                }
                else
                {
                    Console.WriteLine($"  >>  El número a adivinar es más PEQUEÑO que {guessedNumber}.");
                }
                Console.WriteLine("");
                Console.WriteLine("Teniendo en cuenta lo anterior adiviná el nuero y digitalo:");
                guessedNumber = Int32.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
            Console.WriteLine($"Exelente, el numero aleatorio era {randomNumber}, adivinaste esta mondá en {cont} intentos.");


            /*
            int z = 10;

            do{
                Console.WriteLine($"Impresión {z}.");
                z++;
            } while (z < 10);
            */
        }
    }
}
