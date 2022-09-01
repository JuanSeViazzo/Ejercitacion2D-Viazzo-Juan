using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {

        private string nombre;
        private string apellido;
        private string domicilio;
        private string telefono;
        private Mascota[] mascotas;

        private Cliente()
        {
            mascotas = new Mascota[20];
        }

        public Cliente(string nombre, string apellido, string domicilio, string telefono) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
        }

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public string Domicilio { get => domicilio;}
        public string Telefono { get => telefono;}
        public Mascota[] Mascotas { get => mascotas;}

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Apellido: {Apellido}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Domicilio: {Domicilio}");
            sb.AppendLine($"Telefono: {Telefono}");

            foreach (Mascota item in mascotas)
            {
                if (item != null)
                    sb.Append($"{item.ToString()}");
                else
                    break;
            }
            return sb.ToString();   
        }


        public bool AgregarMascota(Mascota mascota)
        {
            if (mascota is not null)
            {
                for (int i = 0; i < mascotas.Length; i++)
                {

                    if (mascotas[i] == mascota)
                    {
                        break;
                    }else
                    {
                        if (mascotas[i] == null)
                        {
                            mascotas[i] = mascota;
                            return true;
                        }
                    }

                }

            }return false;  

        }
    }
}
