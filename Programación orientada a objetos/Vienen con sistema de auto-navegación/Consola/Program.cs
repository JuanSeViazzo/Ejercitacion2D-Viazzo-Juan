using System;
using Logica;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Empresa empresa = new Empresa("La Lujanera");
            Conductor conductor1 = new Conductor("Juan");
            Conductor conductor2 = new Conductor("Jose");
            Conductor conductor3 = new Conductor("Luis");
            empresa.conductores[0] = conductor1;
            empresa.conductores[1] = conductor2;
            empresa.conductores[2] = conductor3;


            foreach (Conductor item in empresa.conductores)
            {
                Random rand = new Random();
                
                for (int i = 0; i < item.kmPorDia.Length; i++)
                {
                    item.kmPorDia[i] = rand.Next(0,100);
                    Console.WriteLine(item.kmPorDia[i]);

                }
                Console.WriteLine("------------------------");

            }

            Console.WriteLine($"El Mayor Km es: {empresa.MayorKmConductor().nombre} ");











            Console.ReadKey();  





        }
    }
}
