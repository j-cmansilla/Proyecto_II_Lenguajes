using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_II
{
    public static class Suma
    {
        public static bool isAccepted(char cadena) { 
        switch (cadena)
            {
                case '|':
                    return true;
                case '+':
                    return true;
                case 'ß':
                    return true;
                default:
                    return false;
            }
        }
    }
}
