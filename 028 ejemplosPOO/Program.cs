// See https://aka.ms/new-console-template for more information

using System;

namespace ejemplosPOO
{
    class Circle
    {
        private const double pi = 3.1416; // Propiedad de la clase circulo. Campo de clase.
                                          // Private, encapsulamos la propiedad pi ya que requiere
                                          // ser vista unicamente dentro de la clase Circle dentro de
                                          // su ambito y no debe ser vista
                                          // desde afuera de dicha clase o ambito, no es necesario.

        public  double CalculoArea(int radio) // Metodo de clase, Que pueden hacer los objetos de tipo circulo.
        {
            return pi * radio * radio;
        }

    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return euro * cantidad;
        }
        public void cambiaValorEuro (double nuevoValor) 
        {
            if (nuevoValor< 0) euro = 1.253;

            else
                euro =  nuevoValor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiaValorEuro(-1.05);

            Console.WriteLine(obj.Convierte(50));

            //Console.WriteLine("Hello, World!");
            Circle miCirculo; // Creacion de objeto de tipo cilculo, variable/objeto de tipo cilculo.
            miCirculo = new Circle(); // Iniciacion de variable/objeto de tipo circulo. Instanciar una clase.
                                      //Instanciación, Ejemplarización, Creacion de ejemplar de clase.

            Circle miCirculo2 = new Circle();

            Console.WriteLine(miCirculo.CalculoArea(5));

            Console.WriteLine(miCirculo2.CalculoArea(9));

            //miCirculo.pi=50.45;

            //Console.WriteLine(miCirculo.CalculoArea(5));
        }
    }
}

