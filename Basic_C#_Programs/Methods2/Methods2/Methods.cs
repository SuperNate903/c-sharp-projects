using System;
using System.Collections.Generic;
using System.Text;

namespace Methods2
{
    class Methods
    {
        public Methods()
        {

        }

        public int Operation(int number)
        {
            return number + 12;
        }

        public int Operation(decimal decimalNum)
        {
            return Convert.ToInt32(decimalNum / 4);
        }

        public int Operation(string stringNum)
        {
            return Convert.ToInt32(stringNum) * 3;
        }
    }
}
