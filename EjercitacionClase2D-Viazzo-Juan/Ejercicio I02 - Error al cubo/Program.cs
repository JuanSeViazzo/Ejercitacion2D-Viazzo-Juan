using System;
//Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".


namespace Ejercicio_I02___Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int cuadrado;
            int cubo;

            do
            {
             Console.WriteLine("Por favor ingrese un numero");
             int.TryParse(Console.ReadLine(), out numero);

            } while (numero < 0);


            Console.WriteLine($"el cuadrado es: {Math.Pow(numero,2)}, el cubo es: {Math.Pow(numero,3)}");

            Console.ReadKey();
                


        }
    }
}
