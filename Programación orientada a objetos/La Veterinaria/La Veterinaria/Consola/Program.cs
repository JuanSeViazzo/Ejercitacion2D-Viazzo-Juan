using System;
using Logica;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Cliente cliente1 = new Cliente("Juan","Viazzo","Balcarce 50","111421414");
            Mascota perrito1 = new Mascota("Perro", "Pepito",Convert.ToDateTime("10/10/2015"));
            Mascota gatito1 = new Mascota("Gato", "Sessa", DateTime.Parse("05/04/2018"));



            cliente1.AgregarMascota(perrito1);
            cliente1.AgregarMascota(gatito1);
            perrito1.CargarVacuna("Antirrabica");
            gatito1.CargarVacuna("Desparacitaria");

            Console.WriteLine(cliente1.Mostrar());

            Console.ReadKey();
        }
    }
}
