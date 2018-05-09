using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_II
{
    public static class Copiar
    {
        public static bool isAccepted(char cadena)
        {
            switch (cadena)
            {
                case 'a':
                    return true;
                case 'b':
                    return true;
                case 'c':
                    return true;
                case 'X':
                    return true;
                case 'Y':
                    return true;
                case 'Z':
                    return true;
                case 'A':
                    return true;
                case 'B':
                    return true;
                case 'C':
                    return true;
                case 'ß':
                    return true;
                default:
                    return false;
            }
        }
    }
}
