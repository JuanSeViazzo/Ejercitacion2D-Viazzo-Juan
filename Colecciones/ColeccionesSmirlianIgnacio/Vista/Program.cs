using System;
using System.Collections.Generic;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool opcion;
            int opcionMaquina;

            //Dictionary<int, Producto> maquinaExpendedora = new Dictionary<int, Producto>();

            Dictionary<int, Stack<Producto>> maquinaExpendedora = new Dictionary<int, Stack<Producto>>();


            //maquinaExpendedora.Add(1, new Producto("Coca-Cola", 200));
            //maquinaExpendedora.Add(2, new Producto("Lays", 220));
            //maquinaExpendedora.Add(3, new Producto("Sprite", 200));
            //maquinaExpendedora.Add(4, new Producto("Bizcochitos Don Satur", 135));
            //maquinaExpendedora.Add(5, new Producto("Sonrisas", 110));
            //maquinaExpendedora.Add(6, new Producto("Cindor", 100));
            //maquinaExpendedora.Add(7, new Producto("Turron arcor", 70));
            //maquinaExpendedora.Add(8, new Producto("Mantecol", 150));
            //maquinaExpendedora.Add(9, new Producto("Alfajor Jorgito", 120));
            //maquinaExpendedora.Add(10, new Producto("Fanta", 200));


            Stack<Producto> CocaCola = new Stack<Producto>();
            Stack<Producto> Lays = new Stack<Producto>();
            Stack<Producto> Sprite = new Stack<Producto>();
            Stack<Producto> BizcochitosDonSatur = new Stack<Producto>();
            Stack<Producto> Sonrisas = new Stack<Producto>();
            Stack<Producto> Cindor = new Stack<Producto>();
            Stack<Producto> TurronArcor = new Stack<Producto>();
            Stack<Producto> Mantecol = new Stack<Producto>();
            Stack<Producto> Alfajor = new Stack<Producto>();
            Stack<Producto> Fanta = new Stack<Producto>();



            for (int i = 0; i < 5; i++)
            {
                CocaCola.Push(new Producto("Coca Cola", 200));
                Lays.Push(new Producto("Lays", 220));
                Sprite.Push(new Producto("Sprite", 200));
                BizcochitosDonSatur.Push(new Producto("Bizcochitos Don Satur", 135));
                Sonrisas.Push(new Producto("Sonrisas", 110));
                Cindor.Push(new Producto("Cindor", 100));
                TurronArcor.Push(new Producto("Turron arcor", 70));
                Mantecol.Push(new Producto("Mantecol", 150));
                Alfajor.Push(new Producto("Alfajor Jorgito", 120));
                Fanta.Push(new Producto("Fanta", 200));
            }

            maquinaExpendedora.Add(1, CocaCola);
            maquinaExpendedora.Add(2, Lays);
            maquinaExpendedora.Add(3, Sprite);
            maquinaExpendedora.Add(4, BizcochitosDonSatur);
            maquinaExpendedora.Add(5, Sonrisas);
            maquinaExpendedora.Add(6, Cindor);
            maquinaExpendedora.Add(7, TurronArcor);
            maquinaExpendedora.Add(8, Mantecol);
            maquinaExpendedora.Add(9, Alfajor);
            maquinaExpendedora.Add(10, Fanta);


            do
            {
                Console.WriteLine($"______________________ \n \"Listado de Productos\"");


                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    if (item.Value.Count > 0)
                        Console.WriteLine($"N° de orden -> {item.Key} - Producto : {item.Value.Peek().Mostrar()}");
                }

                Console.Write("Por favor, elija el N° de producto que quiere llevar: ");

                if (int.TryParse(Console.ReadLine(), out opcionMaquina))
                {
                    if (maquinaExpendedora.ContainsKey(opcionMaquina))
                    {
                        if (maquinaExpendedora[opcionMaquina].Count > 0)
                        {
                            Console.WriteLine($"\n ***** | Producto elegido -> {maquinaExpendedora[opcionMaquina].Peek().Mostrar()} | *****");
                            maquinaExpendedora[opcionMaquina].Pop();
                        }
                        else
                            Console.WriteLine("\n ***!IMPORTANTE!*** - El producto se encuentra agotado");
                    }
                    else
                        Console.WriteLine("El numero ingresado esta fuera de rango");


                }
                Console.WriteLine($"______________________ \n \"Productos Restantes\"");

                foreach (KeyValuePair<int, Stack<Producto>> item in maquinaExpendedora)
                {
                    if (item.Value.Count > 0)
                        Console.WriteLine($"N° de orden -> {item.Key} - Producto : {item.Value.Peek().Mostrar()}");

                }

                Console.WriteLine($"______________________ \n\n \"^-^ Is time to choose ^-^\"\n");


                Console.Write("Por favor presione S para salir, cualquier otra tecla para continuar: ");

                opcion = OpcionElegida(Console.ReadLine());


            } while (opcion is true);

            bool OpcionElegida(string str)
            {
                return !(str is "S");

            }


            //do
            //{
            //    Console.WriteLine($"______________________ \n \"Listado de Productos\"");


            //    foreach (KeyValuePair<int,Producto> item in maquinaExpendedora)
            //    {             
            //            Console.WriteLine($"N° de orden -> {item.Key} - Producto : {item.Value.Mostrar()}");
            //    }

            //    Console.Write("Por favor, elija el N° de producto que quiere llevar: ");

            //    if (int.TryParse(Console.ReadLine(), out opcionMaquina))
            //    {
            //        if (maquinaExpendedora.ContainsKey(opcionMaquina))
            //        {
            //            Console.WriteLine($"\n ***** | Producto elegido -> {maquinaExpendedora[opcionMaquina].Mostrar()} | *****");
            //            maquinaExpendedora.Remove(opcionMaquina);
            //        }
            //        else
            //        {
            //            if (opcionMaquina > maquinaExpendedora.Count)
            //            {
            //                Console.WriteLine("El numero ingresado esta fuera de rango");
            //            }else
            //            Console.WriteLine("\n ***!IMPORTANTE!*** - El producto se encuentra agotado");

            //        }

            //    }
            //    Console.WriteLine($"______________________ \n \"Productos Restantes\"");

            //    foreach (KeyValuePair<int, Producto> item in maquinaExpendedora)
            //    {
            //        if (item.Value is Producto)
            //        {
            //            Console.WriteLine($"N° de orden -> {item.Key} - Producto : {item.Value.Mostrar()}");

            //        }
            //    }

            //    Console.WriteLine($"______________________ \n\n \"^-^ Is time to choose ^-^\"\n");


            //    Console.Write("Por favor presione S para salir, cualquier otra tecla para continuar: ");

            //    opcion = OpcionElegida(Console.ReadLine());


            //}while(opcion is true);

            // bool OpcionElegida(string str)
            //{
            //    return !(str is "S");

            //}

            Console.ReadKey();



        }
    }
}
