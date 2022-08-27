/*Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */
using System;
using Logica;

namespace Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo;
            int minimo;
            int valor;
            int i=0;
            int flag = 0;
            int acumulador=0;
            int minIngresado=0;
            int maxIngresado=0;

            do
            {
                if(flag==1)
                    Console.WriteLine("Error: El rango minimo es mayor al maximo\n");

                Console.WriteLine("Por favor ingrese el rango minimo");
                while (!int.TryParse(Console.ReadLine(), out minimo))
                {
                    Console.WriteLine("Por favor ingrese el rango minimo");
                }
                Console.WriteLine("Por favor igrese el rango maximo");
                while (!int.TryParse(Console.ReadLine(), out maximo))
                {
                    Console.WriteLine("Por favor igrese el rango maximo");

                }
                flag = 1;
            } while (!(minimo < maximo));
            
            do
            {
             Console.WriteLine("Por favor ingrese un numero");
                while(!int.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("dato incorrecto, por favor ingrese un numero");
                }
                if (Validador.Validar(valor, minimo, maximo))
                    Console.WriteLine("Valor dentro de rango");
                else
                    Console.WriteLine("Valor fuera de rango");
                if (flag == 0)
                {
                    if (maxIngresado < valor)
                    {
                        maxIngresado = valor;
                    }else
                        if (valor < minIngresado)
                    {
                        minIngresado = valor;
                    }
                }else
                {
                    minIngresado = valor;
                    maxIngresado = valor;
                }

                acumulador += valor;
               

                i++;
                flag = 0;

            } while (i<10);


            Console.WriteLine($"El minimo ingresado es {minIngresado}, el maximo ingresado es {maxIngresado} y el promedio es {acumulador/10}");


            Console.ReadKey();



        }
    }
}
