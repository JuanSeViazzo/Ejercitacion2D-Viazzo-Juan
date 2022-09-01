using System;
using System.Text;

namespace Logica
{
    public class Mascota
    {

        private string especie;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string[] vacunas;

        public string Especie { get => especie; }
        public string Nombre { get => nombre; }
        public DateTime FechaDeNacimiento 
        {
            get 
            {
                return fechaDeNacimiento; 

            } 

        }

        private Mascota()
        {
            vacunas = new string[20];
        }

        public Mascota(string especie, string nombre, DateTime fechaDeNacimiento) : this()
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"\nnombre: {nombre}");
            sb.AppendLine($"especie: {especie}");
            sb.AppendLine($"fecha de nacimiento: {fechaDeNacimiento.ToShortDateString()}");
            foreach (string item in vacunas)
            {
                if (item != null)
                {
                    sb.AppendLine($"vacuna: {item}");

                }
                else
                    break;
            }

            return sb.ToString();

        }


        public bool CargarVacuna(string vacuna)
        {
            if (!string.IsNullOrWhiteSpace(vacuna))
            {
                for (int i = 0; i < vacunas.Length; i++)
                {
                    if (vacunas[i] == vacuna)
                    {
                        break;
                    }else
                    {
                        if(vacunas[i] == null)
                        {
                            vacunas[i] = vacuna;
                            return true;
                        }

                    }
                }
            }
            else
                return false;

            


            return false;   

        }

    }
}
