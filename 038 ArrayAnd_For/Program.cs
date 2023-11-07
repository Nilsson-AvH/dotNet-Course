// See https://aka.ms/new-console-template for more information
using System;
namespace ArrayAnd_For
{
    class Empleados
    {
        //Constructor Objects

        //Attribs class fields

        String nombre;
        int edad;

        //Setter and Getter methods
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        //Methods
    }
    class Program
    {
        // Constructor objects

        // Attribs class fields

        // Setter and Getter methods

        //Methods

        //Main method
        static void Main(String[] args)
        {
            //Arrays implicitos: (flexible) no especifica el tipo de datos
            //del array ni su cantidad de datos

            var datos = new[] { "Juan", "Carlos", "España" };

            var valores = new[] { 15, 65, 34, 24, 35, 12, 45, 62, 23, 19.5 }; // Todo a double

            Console.WriteLine(datos[0]);

            // Array de objetos

            Empleados[] arrayEmpleados = new Empleados[2];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 27);

            arrayEmpleados[1] = Ana;

            // Array de tipos o clases anonimas

            var personas = new[]
            {
                new{Nombre="Juan", Edad=19},

                new{Nombre="Maria", Edad=49},

                new{Nombre="Diana", Edad=32}
            };

            for (int i=0; i<=9; i++)
            {

                Console.WriteLine($"El valor del array valores en la posicion {i} es: {valores[i]}");

            }

        }
    }
}