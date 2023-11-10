// See https://aka.ms/new-console-template for more information
using System;

namespace HerenciaIII_Constructores
{
    class Mamiferos
    {
        // Constructor Objects
        public Mamiferos(String nombre) 
        {
            nombreSerVivo = nombre;
        }

        // Attrib class fields
        private String nombreSerVivo;

        // Getter and Setter methods
        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: "+nombreSerVivo);
        }

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
    class Caballo : Mamiferos
    {
        // Constructor objects
        public Caballo(String nombreCaballo):base(nombreCaballo) { }

        // Attrib class fields

        // Getter and Setter methods

        // Methods
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar.");
        }
    }
    class Humano : Mamiferos
    {
        // Constructor objects
        public Humano(String nombreHumano):base(nombreHumano) { }

        // Atribs class fields

        // Getter ads Setter methods

        // Methods
        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar.");
        }
    }
    class Gorila : Mamiferos
    {
        // Constructor objects
        public Gorila(String nombreGorila):base(nombreGorila) { }

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
            Caballo caballo01 = new Caballo("Babieca");

            Humano humano01 = new Humano("Juan");

            Gorila gorila01 = new Gorila("Copito");

            caballo01.getNombre();
            humano01.getNombre();
            gorila01.getNombre();
        }
    }
}