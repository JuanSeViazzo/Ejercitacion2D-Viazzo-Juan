/*1.Crear e instanciar el Dictionary<TKey,TValue> llamado maquinaExpendedora.
2.Cargar por lo menos 10 elementos en formato clave-valor (clave=numero de posición, valor=nombre del producto)
3.Una vez cargado, desarrollar el flujo del proyecto de consola de modo que:
•Al iniciarse muestre al usuario todos los productos con sus respectivos códigos.
•Pida al usuario elegir el número del producto que quiere
•Al seleccionar número, informar al usuario que recibió ese producto y volver a mostrar todos los productos SIN el producto que ya eligió
•El programa se repetirá indefinidamente hasta que el usuario elija la opción “S”.
BONUS: Refactorizar el programa para que en vez de tener un diccionario INT – STRING, tengamos un diccionario INT – PRODUCTO (que contenga nombre y precio del producto)
*/

using System;
using System.Collections.Generic;

namespace ColeccionesEnClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Producto papaFrita = new Producto("PapaFrita",50);
            Producto CocaCola = new Producto("CocaCola",30);
            Producto Cerveza = new Producto("Cerveza", 40);

            Console.WriteLine(papaFrita.codigo);
            Console.WriteLine(CocaCola.codigo);
            Console.WriteLine(Cerveza.codigo);


            Stack<Producto> cervezas = new Stack<Producto>();



            Dictionary<int, string> maquinaExpendedora = new Dictionary<int, string>();
            maquinaExpendedora.Add(1, "Tuistos");
            maquinaExpendedora.Add(2, "Cerveza");
            maquinaExpendedora.Add(3, "Chegusan JyQ");
            maquinaExpendedora.Add(4, "DRF");
            maquinaExpendedora.Add(5, "Lays");
            maquinaExpendedora.Add(6, "CocaCola");
            maquinaExpendedora.Add(7, "Ensalada");
            maquinaExpendedora.Add(8, "Mortadela");
            maquinaExpendedora.Add(9, "Alfajor Capitan del Espacio");
            maquinaExpendedora.Add(10, "Milanesa");

            foreach (KeyValuePair<int,string> item in maquinaExpendedora)
            {
                Console.WriteLine($"Orden: {item.Key} - Producto {item.Value}");

            }
           



            Console.WriteLine("Por favor elija un producto");

            if(int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine($"Usted eligio el siguiente producto: {maquinaExpendedora[opcion]}");
            }

            maquinaExpendedora.Remove(opcion);

            foreach (KeyValuePair<int, string> item in maquinaExpendedora)
            {
                Console.WriteLine($"Orden: {item.Key} - Producto {item.Value}");

            }


            Console.ReadKey();
        }
    }
}
