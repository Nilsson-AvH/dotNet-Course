// See https://aka.ms/new-console-template for more information
using System;

namespace CondicionalIFBoolean
{
    /*
    * OPERADORES DE COMPARACION:
    * ==   igual que
    * !=   diferente que
    * <    menor que
    * <=   menor o igual que
    * >    mayor que
    * >=   mayor o igual que
    * 
    * OPERADORES LOGICOS:
    * &&   AND
    * ||   OR
    */
    class Program
    {
        
        //All methods


        //Main method
        static void Main (string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un coche.");
            Console.WriteLine("Introduce tu edad por favor");
            int edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tienes carnet?");
            string carnet = Console.ReadLine();

            if (edad >= 18 && carnet == "si") Console.WriteLine("Puedes conducir vehiculos");
            else Console.WriteLine("No puedes conducir vehiculos");



            /*
            Console.WriteLine("Vamos a evaluar si puedes conducir un coche.");
            bool carnet = false;
            
            if (carnet) // es lo mismo que if(carnet==true)
            {
                Console.WriteLine("Puedes conducir coches");
            }
            else
            {
                Console.WriteLine("No puedes conducir coches");
            }
            */

            Console.WriteLine("Aqui termina el programa, gracias.");
            //Console.WriteLine("Hello, World!");
            /*
            bool haceFrio;
            haceFrio = true; 
            Console.WriteLine(!haceFrio);// ! invertir valor de la expresion 
            */
        }
    }
}
    
