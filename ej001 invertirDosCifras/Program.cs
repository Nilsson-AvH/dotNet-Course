// See https://aka.ms/new-console-template for more information
using System;
namespace InvertirDosCifras
{
    class Invertir
    {
        private int DEC, UNI;
        public int InvertirDosNuemros(int NUM)
        {
            DEC = NUM/10;
            UNI = NUM%10;
            return (UNI*10)+DEC;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Invertir obj = new Invertir();
            Console.WriteLine("Programa para invertir numero de dos cifras.");
            Console.WriteLine("Ingrese el número a invertir: ");
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input >= 10 && input <= 99) Console.WriteLine(input+ " invertido es: "+ obj.InvertirDosNuemros(input));
                else Console.WriteLine("El numero digitado no es de dos cifras.");
            }
            catch(FormatException ex) 
            {
                Console.WriteLine("Ha introducido un valor que no es numerico.");
            }            
        }
    }
}