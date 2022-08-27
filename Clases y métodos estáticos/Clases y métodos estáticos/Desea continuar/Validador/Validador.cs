using System;

namespace Logica
{
    public class Validador
    {


        public static bool Validar(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || valor != "S")
                return false;
            else
                return true;

        }

    }
}
