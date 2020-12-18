using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_NUnit
{
    public static class Calculator
    {
        static public int Plus (int x, int y)
        {
            return x + y;
        }

        static public int Minus(int x, int y)
        {
            return x - y;
        }

        static public int Multiplication(int x, int y)
        {
            return x * y;
        }

        static public int Division(int x, int y)
        {
            if (y == 0)
                return 0;
            return x / y;
        }
    }
}
