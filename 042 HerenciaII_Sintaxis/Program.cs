// See https://aka.ms/new-console-template for more information
using System;

namespace HerenciaII_Sintaxis
{
    class Mamiferos
    {
        // Constructor Objects

        // Attrib class fields

        // Getter and Setter methods

        // Methods
        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar.");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Puedo cuidar de mis crias hasta que se valgan por si solas.");
        }
    }
    class Caballo:Mamiferos
    {
        // Constructor objects

        // Attrib class fields

        // Getter and Setter methods

        // Methods
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar.");
        }
    }
    class Humano:Mamiferos
    {
        // Constructor objects

        // Atribs class fields

        // Getter ads Setter methods

        // Methods
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar.");
        }
    }
    class Gorila:Mamiferos
    {
        // Constructor objects

        // Attrib class fields

        // Getter and Setter methods

        // Methods
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar.");
        }
    }
    class Program
    {
        // Constructor objects

        // Attrib class field

        // Getter and Setter methods

        // Methods

        // Main Method
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");
            Caballo Babieca = new Caballo();

            Humano Juan = new Humano();

            Gorila Copito = new Gorila();

            Copito.trepar();
            Copito.respirar();
        }
    }
}

