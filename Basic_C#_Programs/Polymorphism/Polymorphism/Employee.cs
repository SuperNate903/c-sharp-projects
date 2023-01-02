using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("You have quit the table.");
            Console.ReadLine();
        }
    }
}
