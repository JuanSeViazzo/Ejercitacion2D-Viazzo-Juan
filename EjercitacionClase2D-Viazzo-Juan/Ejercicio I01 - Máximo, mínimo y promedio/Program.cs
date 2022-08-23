using System;

namespace Ejercicio_I01___Máximo__mínimo_y_promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float maximo=float.MinValue;
            float minimo=float.MaxValue;
            float promedio=0;
            float numero;
            int i;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Por favor ingrese un numero");
                float.TryParse(Console.ReadLine(), out numero);
                maximo = Math.Max(numero, maximo);
                minimo = Math.Min(numero, minimo);
                promedio= promedio + numero;    



            }
            promedio = promedio / i;

            Console.WriteLine($"El maximo es: {maximo}, el minimo es {minimo}, el prom es {promedio}", maximo,minimo, promedio);


            Console.ReadKey();




        }
    }
}
