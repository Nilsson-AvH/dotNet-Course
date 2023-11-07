// See https://aka.ms/new-console-template for more information

using System;

namespace exepciones
{
    class Program
    {
        // All methods

        // Main method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);
            int miNumero;
            int cont = 0;

            Console.WriteLine("Introduce un numero entre 1 y 100:");

            do {
                cont++;

                try
                {

                    miNumero = int.Parse(Console.ReadLine());

                }
                catch(FormatException ex) 
                { 
                    Console.WriteLine($"No has introducido un valor numercio válido, se toma como numero introducido el cero, cod: {ex.Message}");
                    miNumero = 0;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine($"Has introducido un numero muy alto, se toma como numero introducido el cero, cod: {ex.Message}");
                    miNumero = 0;
                }

                if (miNumero > aleatorio) Console.WriteLine("El número es mas bajo.");
                if (miNumero < aleatorio) Console.WriteLine("El número es mas alto.");

            } while(aleatorio!=miNumero);
                Console.WriteLine($"Correcto, has necesitado {cont} intentos.");
            Console.WriteLine("A partir de esta linea de codigo el programa continuaria");

        }
    }
    
}


