// See https://aka.ms/new-console-template for more information
using System;

namespace UsoArrays
{
    class Empleados
    {
        // Constructor Objects

        // Attrib class fields
        private string nombre;
        private int edad;

        // Setter and Getter methods
        public String getInfo()
        {
            return "Nombre del empleado: " + nombre + ", edad del empleado: " +edad+".";
        }

        // Methods
        public Empleados(string nombre, int edad) 
        {
            this.nombre = nombre;
            this.edad = edad;

        }

    }
    class Program
    {
        // Constructor Objects

        // Attribs class fields

        // Setter and Getter methods

        // Methods

        // Main method
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var valores = new[] { 15, 28, 35, 75.5, 30.30, 90, 85.2 };



            Empleados Ana = new Empleados("Ana", 32);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sahara", 37);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 51);

            /*
            for (int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }
            */
            foreach (Empleados variable in arrayEmpleados) 
            {
                Console.WriteLine(variable.getInfo());
            }

            foreach (Double item in valores)
            {
                Console.WriteLine(item);
            }
        }
    }
}