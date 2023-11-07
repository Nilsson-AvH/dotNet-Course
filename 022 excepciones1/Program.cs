// See https://aka.ms/new-console-template for more information
using System;

namespace excepciones 
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int miNumero;
            int intentos = 0;
            Console.WriteLine("Introdue un numero entre 0 y 100.");

            do {
                intentos++;

                try
                {
                    miNumero = int.Parse(Console.ReadLine());
                }
                /*catch(FormatException ex) // Video 022 
                {
                    Console.WriteLine("No ha introducido un valor numerico válido. SE TOMA COMO NUMERO INTRODUCIDO EL 0.");
                    miNumero =0;
                }
                catch(OverflowException ex)
                {
                    Console.WriteLine("Has introducido un valor denasiado alto. SE TOMA COMO NUMERO INTRODUCIDO EL 0.");
                    miNumero =0;
                }*/

                /*catch (FormatException ex)
                {
                    Console.WriteLine("Has introducido texto");
                    miNumero =0;
                }*/

                catch (Exception ex) when (ex.GetType()!=typeof(FormatException)) // Video 023
                {
                    Console.WriteLine("Ha habido un error. SE TOMA COMO NUMERO INTRODUCIDO EL 0.");
                    //Console.WriteLine(ex.Message);

                    miNumero =0;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Has introducido texto, catch con when.");
                    miNumero = 0;
                }
                

                if (miNumero > aleatorio) Console.WriteLine("El N° es más bajo.");

                if (miNumero < aleatorio) Console.WriteLine("El N° es más alto.");

            } while (aleatorio != miNumero);
                Console.WriteLine($"¡Correcto! has necesitado {intentos} intentos.");
            Console.WriteLine("A partir de esta linea el código del programa continuaria.");
        }
    }
}
