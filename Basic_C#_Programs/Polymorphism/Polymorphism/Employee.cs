using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("You have quit the table.");
            Console.ReadLine();
        }
    }
}
