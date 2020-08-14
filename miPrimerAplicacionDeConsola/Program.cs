using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int edad; // declaración
            edad = 34; // asignación
            double temperatura = 15.7; // declaración y asignación en la misma línea
            float pi = 3.14f;
            string nombre = "Jesús Arce";
            bool x = true;

            // operaciones aritméticas
            int suma = 5 + 2;
            int resta = 5 - 2;
            double division = 5 / 2;
            int multiplicacion = 5 * 2;
            int resto = 5 % 2;
            int operacion = 5 * 2 + 8; // aquí se ejecuta primero la multiplicación
            int operacion2 = 5 * (2 + 8); // se ejecuta primero la suma

            // mostramos resultados por consola
            Console.WriteLine("Hola " + nombre + ", tu edad es " + edad);
            Console.WriteLine("Hola {0}, tu edad es {1}", nombre, edad);

            // solicitar datos al usuario
            string cadenaDeEntrada = "";
            Console.WriteLine("Por favor, ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ok, su nombre es: " + nombre);

            Console.WriteLine("Por favor, ingrese su edad: ");
            cadenaDeEntrada = Console.ReadLine();

            try
            {
                edad = Convert.ToInt32(cadenaDeEntrada);
            }
            catch(Exception ex){
                Console.WriteLine(ex);
            }
            
            edad = edad - 1;
            Console.WriteLine("Ok, su edad es: " + edad);

            Console.ReadKey();
        }
    }
}
