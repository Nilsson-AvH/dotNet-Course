using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_conceptosPOO
{
    internal class Punto
    {
        // CONSTRUCTOR
        public Punto() 
        {
            x = 0; 
            y = 0;
            Console.WriteLine("Este es el constructor por defecto.");
            Console.WriteLine($"Coordenada x: {x}\nCoordenada y: {y}\n");
        }
        public Punto(int x, int y) 
        {
            Console.WriteLine($"Este es el constructor con sobrecarga de operadores.");
            Console.WriteLine($"Coordenada x: {x}\nCoordenada y: {y}");
        }

        // ATTRIBUTES
        private int x;

        private int y;

        // METHODS

        // SETTER AND GETTER METHODS

    }
}
