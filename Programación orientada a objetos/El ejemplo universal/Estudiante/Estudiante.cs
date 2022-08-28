using System;
using System.Text;

namespace Logica
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        Random random;

        static Estudiante()
        {
            Random random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public int NotaPrimerParcial { set => notaPrimerParcial = value; }
        public int NotaSegundoParcial { set => notaSegundoParcial = value; }
        public string Apellido { get => apellido; }
        public string Legajo { get => legajo; }
        public string Nombre { get => nombre; }

        private float CalcularPromedio()
        {
            float promedio;
            return promedio = (notaPrimerParcial + notaSegundoParcial)/2;
        }


        public double CalcularNotaFinal()
        {
            Random rnd = new Random();  
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
                return rnd.Next(6, 10);
            else
                return -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Legajo: {Legajo}");
            sb.AppendLine($"Nota primer parcial {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial {notaSegundoParcial}");
            sb.AppendLine($"Nota Promedio: {CalcularPromedio()}");

            if (CalcularNotaFinal() != -1)
                sb.AppendLine($"Nota final: {CalcularNotaFinal()}");
            else
                sb.AppendLine($"Alumno Desaprobado");


            return sb.ToString();

        }




    }
}
