using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Cliente.Formulario
{
    public static class Validaciones
    {
        public static bool PedirString(string a)
        {
            if (a == string.Empty)
            { return false; }
                    

            return true;
        }

        public static int PedirInt(string a)
        {
           
            if (!int.TryParse(a, out int numero))
            {
                return numero;
            }
            return -1;
        }
               
    }
}
