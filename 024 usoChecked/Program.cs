// See https://aka.ms/new-console-template for more information

using System;

namespace usoChecked
{
    class Program
    {
        // All methods

        // Main method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            checked {   // Sin este checked, el programa sumaria 20 al maximo numero permitido int
                        // y quedaria un numero negativo, es error pero, por cuestion de rendimiento de c#
                        // lo hace de esta forma con el fin de no hacer checked a cada operacion
                        // matematica dentro de un programa ya que esto si sería muy ineficiente.
                        // Se imaginan un programa con 700 operaciones aritmeticas y que el compilador
                        // tenga que revisarlas una por una cada vez que en una variable nosotros
                        // ingresemos un valor.

                int numero = int.MaxValue;
                Console.WriteLine(numero);

                int resultado = numero + 20; // Maximo int y le suma 20
                Console.WriteLine(resultado);

                // Si queremos que el compilador haga el checked automaticamente a todo un programa sin
                // hacer uso de sentencias checked a cada operacion aritmetica, hacemos lo siguiente:

                // Click derecho sobre nuestro proyecto en la ventana izquierda Solution Explorer.
                // Menú contextual hacemos click en Properties
                // Build > Advanced > Check for arithmetic overflow
                // Activamos > Throw exceptions when integer arithmetic produces out of range values.
                // Guardamos y aceptamos todo (Ctrl + S) y listo
                // Es como si hubiesemos escrito el checked en el programa.

            }

        }
    }
}