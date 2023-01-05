using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    public class ChainConstruct
    {
        public ChainConstruct(int number) : this(number, 5)
        {
            
        }

        public ChainConstruct(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.ReadLine();
        }
    }
}
