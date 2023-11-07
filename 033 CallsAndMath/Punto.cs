using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_CallsAndMath
{
    internal class Punto
    {
        // CONSTRUCTOR objetos
        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto.");
            this.x = 0; 
            this.y = 0;
            contadorDeObjetos++;
        }
        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x}\nCoordenada y: {y}");
            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        // ATTRIBUTES Campos de clase
        private int x, y;

        private static int contadorDeObjetos = 0;

        // SETTER AND GETTER METHODS
            
        public static int getContadorDeObjetos()
        {
            return contadorDeObjetos;
        }

        // METHODS

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2)+Math.Pow(yDif, 2));

            return distanciaPuntos;
        }
    }
}
