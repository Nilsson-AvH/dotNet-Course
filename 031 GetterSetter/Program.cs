// See https://aka.ms/new-console-template for more information
using System;

namespace UsoCoches
{
    class Coche
    {
        // CONSTRUCTOR
        /* El constructor:
           El constructor no es ni más ni menos que un método un poco especial,
           un método que tiene como nombre obligatoriamente el mismo nombre que la clase 
           y además ese método no podrá devolver ningún dato y tampoco será void, además
           El constructor nos contruye el estado inicial es decir cómo se encuentra ese 
           coche cuál es su comportamiento por defecto y cuáles son sus características por defecto.        
         */
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }
        // SOBRECARGA DE CONSTRUCTORES
        /*
         Cuendo quiero que el estado inicial de mi objeto sea diferente en este caso que tenga diferente
        largo y ancho.
         */
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }

        // ATTRIBUTES (Caracteristica o Propiedad)
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        // METHODS (Funciones)

        // GETTER METHODS GET = OBTENER
         /*
         Creando metodos de acceso GETTER para que nuestros atribustos sean private que es lo correcto.
         */

        public String getInfoCoche()
        {
            return "\nInformación del coche:\n\n" + "Ruedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho;
        }
        public int getRuedas() // Metodo de acceso
        {
            return ruedas;
        }
        
        // SETTER METHOD SET = ESTABLECER
        /*
         Los metodos set son de tipo void porque ESTABLECEN un valor o info a los atributos de mi clase
        y por consiguiente no van retornar ningún valor.
         */

        public void setExtras(bool climatizador, String tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        public String getExtras()
        {
            return "Extras del coche: \n" + "Tapicería: " + tapiceria + "\nClimatizador: " + climatizador;        }
        }
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Vamos a crear objetos de tipo coche para ello nos vamos a ir al main de la 
           clase principal y para crear nuestro primer coche lo que hacemos es escribir: 
           nombre de la clase a continuación nombre del objeto o instancia perteneciente 
           a la clase coche pues no se me ocurre ninguno voy a llamarle Coche1 igual a new y 
           nombre del constructor. Esta instrucción que ya la hemos visto anteriormente en el 
           curso con la clase circulo si recordáis lo que hace no es ni más ni menos que crear 
           un objeto o instancia perteneciente a la clase coche dicho de otra forma para ir 
           familiarizándonos con esta jerga del lenguaje orientado a objetos lo que hemos hecho 
           con esta instrucción ha sido instanciar la clase coche ha habido una instanciación y 
           lo que hacemos con la palabra reservada new no es ni más ni menos que llamar al 
           constructor es decir con esta instrucción que acabamos de crear lo que hemos hecho 
           ha sido pues 2 cosas por un lado crear objeto de tipo coche objeto o instancia vamos 
           a ponerlo también y por otro lado lo que hemos hecho también con esta instrucción 
           es lo voy a poner debajo dar un estado inicial a nuestro coche.
            */
            Coche coche1 = new Coche(); // Instanciar la clase
            Coche coche2 = new Coche(); // Instanciar la clase
            Coche coche3 = new Coche(4500.25, 1200.35); // Instanciar la clase con parametros 

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            coche3.setExtras(true, "Cuero");
            Console.WriteLine(coche3.getInfoCoche());
            Console.WriteLine(coche3.getExtras());
        }
    }
}