using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1.Helpers
{
    public class Helper
    {
        public static int transformar (int numero)
        {
            string binario="";
            while (numero > 0)
            {
                binario = numero % 2 + binario;
                numero = numero / 2;
            }

            return Convert.ToInt32(binario);
        }
    }
}
