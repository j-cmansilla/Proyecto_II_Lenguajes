using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_II
{
    public static class MultUnaria
    {
        public static bool isAccepted(char cadena)
        {
            switch (cadena)
            {
                case '|':
                    return true;
                case '*':
                    return true;
                case '=':
                    return true;
                case 'ß':
                    return true;
                case 'X':
                    return true;
                case 'Y':
                    return true;
                default:
                    return false;
            }
        }
    }
}
