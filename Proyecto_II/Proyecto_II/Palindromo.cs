using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_II
{
    public static class Palindromo
    {
        public static char[] cadena;
        public static int currentState;
        public static int currentIndex;
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

        public static int getNextState(char currentToken)
        {
            if (!isAccepted(currentToken))
            {
                return -1;
            }
            if (currentState != 0)
            {
                return currentState;
            }
            else
            {
                if (currentToken.ToString().ToLower().Equals("a"))
                {
                    return 1;
                }
                if (currentToken.ToString().ToLower().Equals("b"))
                {
                    return 2;
                }
                if (currentToken.ToString().ToLower().Equals("c"))
                {
                    return 3;
                }
            }
            return 0;
        }
        public static int getNextIndex(char currentToken)
        {
            if (!isAccepted(currentToken))
            {
                return -1;
            }
            if (currentToken.ToString().ToLower().Equals("a"))
            {
                return 1;
            }
            if (currentToken.ToString().ToLower().Equals("b"))
            {
                return 2;
            }
            if (currentToken.ToString().ToLower().Equals("c"))
            {
                return 3;
            }
            return 0;
        }
        public static int getReplacedString(char currentToken)
        {
            if (!isAccepted(currentToken))
            {
                return -1;
            }
            if (currentToken.ToString().ToLower().Equals("a"))
            {
                return 1;
            }
            if (currentToken.ToString().ToLower().Equals("b"))
            {
                return 2;
            }
            if (currentToken.ToString().ToLower().Equals("c"))
            {
                return 3;
            }
            return 0;
        }
    }
}
