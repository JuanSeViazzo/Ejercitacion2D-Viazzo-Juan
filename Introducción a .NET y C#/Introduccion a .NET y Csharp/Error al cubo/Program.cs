using System;

namespace Error_al_cubo
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


            Console.WriteLine($"el cuadrado es: {Math.Pow(numero, 2)}, el cubo es: {Math.Pow(numero, 3)}");

            Console.ReadKey();
        }
    }
}
