using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Random random = new Random();
            List<int> listaDeNumeros = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numero = random.Next(-100,100);

                if (numero != 0)
                {
                    listaDeNumeros.Add(numero); 
                }

            }

            foreach (int item in listaDeNumeros)
            {
                Console.WriteLine(item);



            }
            Console.WriteLine("Inicio Mayor a Menor");


            for (int i = 0; i < listaDeNumeros.Count; i++)
            {
                listaDeNumeros.Sort(ComparacionOComoQuieras);

                if (listaDeNumeros[i] > 0)
                {
                    Console.WriteLine(listaDeNumeros[i]);

                }


            }

            Console.WriteLine("Inicio de Menor a Mayor");


            for (int i = 0; i < listaDeNumeros.Count; i++)
            {
                listaDeNumeros.Sort(ComparacionDos);

                if (listaDeNumeros[i] > 0)
                {
                    Console.WriteLine(listaDeNumeros[i]);

                }


            }


            Console.ReadKey();



            int ComparacionOComoQuieras(int num1, int num2)
            {
                return num2 - num1;
            }

            int ComparacionDos(int num1, int num2)
            {
                return num1 - num2;

            }

        }
    }
}
