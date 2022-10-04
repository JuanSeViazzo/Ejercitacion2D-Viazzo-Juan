using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescribiendoAdvertencias
{
    public class Sobreescrito
    {

        public string nombre;
        public Sobreescrito(string nombre)
        {
            this.nombre = nombre;   
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Este es mi Metodo ToString sobrescrito");

            return sb.ToString();   
        }

        public override bool Equals(object obj)
        {
            Sobreescrito sobrescrito = obj as Sobreescrito;   
            
             return(sobrescrito != null && this.nombre == sobrescrito.nombre);   

               
        }

        public override int GetHashCode()
        {
            int hash = 1142510181;
            return hash;
        }

    }
}
