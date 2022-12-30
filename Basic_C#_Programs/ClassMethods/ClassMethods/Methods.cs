using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethods
{
    public class Methods
    {
        public void Divide(int num, out int total)
        {
            total = num / 2;
        }

        public void Divide(string stringNum, out int total)
        {
            total = Convert.ToInt32(stringNum) / 5;
        }
    }
}
