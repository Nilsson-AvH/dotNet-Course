﻿// See https://aka.ms/new-console-template for more information

namespace PracticaMetodos3
{
    class Program
    {
        // Sobrecarga de metodos
        static int suma(int operador1, int operador2) => operador1 + operador1;//Expresion bodied
        static int suma(int numero1, double numero2) => numero1;
        static int suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2 + numero3 + numero4;
        
        //Metodo Main
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(suma(7,5.3));
        }
    }
}

