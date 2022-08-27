using System;
using Logica;
/*Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.*/


namespace Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int acumulador=0;
            string respuesta;
            int numero;
            do
            {
                Console.WriteLine("Por favor ingrese un numero");

                if(int.TryParse(Console.ReadLine(), out numero))
                    acumulador += numero;

                Console.WriteLine("Desea continuar? (S/N)");
                respuesta = Console.ReadLine();

            } while (Validador.Validar(respuesta));

            Console.WriteLine($"la suma es {acumulador}");

            Console.ReadKey();  

        }
    }
}
