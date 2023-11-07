// See https://aka.ms/new-console-template for more information
using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a C#");
            /* esto es un comentario de varias lineas
             * mas
             * del mismo
             * comentario */
            int edad = 25;
            edad++;
            edad +=5;
            Console.WriteLine("La edad de la persona es "+ ++edad +" años.");
            //Interpolacion de Strings
            Console.WriteLine($"La edad de la persona es {edad} años. Mensaje con interpolacion.");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("https://www.youtube.com/watch?v=CyG6oaNq8HE&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=6");
            Console.WriteLine("Video 6");
            Console.WriteLine("");
            /*
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;
            Console.WriteLine(edadPersona4);
            */

            /*
            int edadPersona1, edadPersona2, edadPersona3, edadPersona4 = 27;
            // Console.WriteLine(edadPersona1); // Esto me arrojaria error porque la unica variable con valor es edadPersona4
            Console.WriteLine(edadPersona4);
            */

            /*
            var edadPersona = 27; // Declaracion implicita de variables, no se puede editar el tipo de variable
            // edadPersona = 35.2; // Esto no se puede hacer por que estaria cambiando de int a double
            Console.WriteLine(edadPersona);
            */

            double temperatura = 34.5;
            int temperaturaMadrid;

            //conversion explicita o casting
            temperaturaMadrid = (int) temperatura;
            Console.WriteLine(temperaturaMadrid);
            
            //Conversion implicita
            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2018);

            float pesoMaterial = 5.78F; //Una variable tipo float siempre llevará la F mayuscula al final
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine(pesoMaterialPrec);

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("https://www.youtube.com/watch?v=ZheVmw7CCnw&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=7");
            Console.WriteLine("Video 7");
            Console.WriteLine("");

            //Parse de tipos de variables
            Console.WriteLine("Introduce el primer numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de {num1} mas {num2} es: {num1+num2}"); //Interpolacion de Strings

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("https://www.youtube.com/watch?v=j8SYB_77fmE&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=8");
            Console.WriteLine("Video 8");
            Console.WriteLine("");

            // Constantes

            const int VALOR = 5;//Las constantes deben declararse e iniciarse en la misma linea.
                                //Se recomienda declarar las constantes en MAYUSCULAS.
            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es: {1}", VALOR, VALOR2 );

            const double PI = 3.1416;
            Console.WriteLine("Introduce la medida del radio:");
            double radio = double.Parse(Console.ReadLine());

            double areaCirculo = PI * Math.Pow(radio,2);

            Console.WriteLine($"El area de un circulo de radio {radio} es {areaCirculo}.");



        }
            
    }
}