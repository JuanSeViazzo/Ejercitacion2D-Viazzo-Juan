using Entidades;
using System;

namespace EjerEncap1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEncapsulado alumno1 = new AlumnoEncapsulado("Perez", "Agustin", 12345);
            AlumnoEncapsulado alumno2 = new AlumnoEncapsulado("Garcia", "Jorge", 12346);
            AlumnoEncapsulado alumno3 = new AlumnoEncapsulado("Lopez", "Pablo", 12347);

            alumno1.Nota1 = 8;
            alumno2.Nota1 = 7;
            alumno3.Nota1 = 9;

            alumno1.Nota2 = 7;
            alumno2.Nota2 = 9;
            alumno3.Nota2 = 8;

            int notaFinal1 = alumno1.NotaFinal;
            int notaFinal2 = alumno2.NotaFinal;
            int notaFinal3 = alumno3.NotaFinal;

            Console.WriteLine("El alumno: " + alumno1.apellido + ", " + alumno1.nombre + " tiene como nota final: " + notaFinal1);
            Console.WriteLine("El alumno: " + alumno2.apellido + ", " + alumno2.nombre + " tiene como nota final: " + notaFinal2);
            Console.WriteLine("El alumno: " + alumno3.apellido + ", " + alumno3.nombre + " tiene como nota final: " + notaFinal3);


            Console.ReadKey();
        }
    }
}
