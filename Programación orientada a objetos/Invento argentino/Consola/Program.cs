using System;
using Invento_argentino;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dibujoAzul;
            string dibujoRojo;

            Boligrafo BoligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);

            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);


            Console.WriteLine("La tinta azul tiene:{0} unidades", BoligrafoAzul.Tinta);
            Console.WriteLine("La tinta roja tiene:{0} unidades", boligrafoRojo.Tinta);
      
            dibujoAzul = BoligrafoAzul.Pintar(20, out dibujoAzul) == true ? dibujoAzul : null;

            if (dibujoAzul != null)
                Console.ForegroundColor = ConsoleColor.Blue;


            ConsoleColor dibujarEnAzul = Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(dibujoAzul);

            Console.WriteLine("La tinta actual es: {0} ", BoligrafoAzul.Tinta);

            BoligrafoAzul.Recargar();

            Console.WriteLine("Se ha realizado la recarga, la tinta actual es: {0}", BoligrafoAzul.Tinta);


            dibujoRojo = boligrafoRojo.Pintar(10, out dibujoRojo) == true ? dibujoRojo : null;
            if (dibujoRojo != null)
                Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(dibujoRojo);

            Console.WriteLine("La tinta actual es: {0} ", boligrafoRojo.Tinta);

            boligrafoRojo.Recargar();

            Console.WriteLine("Se ha realizado la recarga, la tinta actual es: {0}", boligrafoRojo.Tinta);


            Console.ReadKey();
        }
    }
}
