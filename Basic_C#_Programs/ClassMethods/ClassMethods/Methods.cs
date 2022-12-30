using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethods
{
    public static class Methods
    {
        public static void Divide(int num, out int total)
        {
            total = num / 2;
        }

        public static void Divide(string stringNum, out int total)
        {
            total = Convert.ToInt32(stringNum) / 5;
        }
    }
}
