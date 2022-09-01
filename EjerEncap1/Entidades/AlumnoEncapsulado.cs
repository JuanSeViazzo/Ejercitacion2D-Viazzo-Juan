using System;

namespace Entidades
{
    public class AlumnoEncapsulado
    {
        private int nota1;
        private int nota2;
        public string apellido;
        public string nombre;
        public int legajo;

        public int Nota1 { get => nota1;

             set
            {
                if (value > 0 && int.TryParse(value.ToString(),out value))
                {
                    this.nota1 = value;
                }else
                    this.nota1 = 0;
            } 
	 
         
        }
        public int Nota2 { get => nota2; 
            
             set
            {
                if (value > 0 && int.TryParse(value.ToString(), out value))
                {
                    this.nota2 = value;
                }
                else
                    this.nota2 = 0;
            }
        }

        public int NotaFinal { get => (Nota1 + Nota2) / 2; }

        public AlumnoEncapsulado(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public void TomarExamen(int parcial, int nota)
        {
        }



    }
}
