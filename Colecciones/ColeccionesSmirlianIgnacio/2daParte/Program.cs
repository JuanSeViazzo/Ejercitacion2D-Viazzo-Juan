using System;
using System.Collections.Generic;
namespace _2daParte
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Queue<string> filaDeClientes = new Queue<string>();

            filaDeClientes.Enqueue("Juan");
            filaDeClientes.Enqueue("Nacho");
            filaDeClientes.Enqueue("Lucas");
            filaDeClientes.Enqueue("Esteban");
            filaDeClientes.Enqueue("Pepe");


            foreach (string item in filaDeClientes)
            {
                Console.WriteLine(filaDeClientes.Peek());

            }






        }
    }
}
