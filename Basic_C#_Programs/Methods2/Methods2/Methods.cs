using System;
using System.Collections.Generic;
using System.Text;

namespace Methods2
{
    class Methods
    {
        public static int Operation(int number)
        {
            return number + 12;
        }

        public static decimal Operation(decimal decimalNum)
        {
            return decimalNum / 4;
        }

        public static int Operation(string stringNum)
        {
            return Convert.ToInt32(stringNum) * 3;
        }
    }
}
