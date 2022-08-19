using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharp
{
    internal class Sesion2
    {
        static void Main2(string[] args)
        {
            //Ejercicio 1 - Lee datos de una persona y devuelve en consola
            Console.WriteLine("Escribe tu nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad:");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Sabes programar? Ingresa SI o NO");
            Boolean sabeProgramar = ((Console.ReadLine().ToLower()) == "si") ? true : false;
            Console.WriteLine($"Tu nombre es {nombre} tienes {edad} años y {((sabeProgramar == true) ? "si sabes programar" : "no sabes programar")}");

            //Ejercicio 2 - Descripcion de objetos
            //Coche
            int puertas = 5;
            int ruedas = 4;
            string marca = "nissan";
            Boolean itvVigente = false;
            //Mesa
            double peso = 5.5;
            double largo = 2.5;
            string material = "pino";
            string color = "negra";

            //Ejercicio 3
            Boolean mayorIgual18 = 22 > 18;
            Boolean charIgual = 'B' == 'a';
            Boolean ambasCondicionesTrue = 22.GetType() == typeof(int) && 22 > 10;
            Boolean unaCondicionTrue = 22.GetType() == typeof(int) || 22 > 99999;

        }
    }
}
