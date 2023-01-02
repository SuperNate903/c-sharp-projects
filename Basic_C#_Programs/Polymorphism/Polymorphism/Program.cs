using System;

namespace Polymorphism
{
    class Program
    {
        static void Main()
        {
            IQuittable quitTable = new Employee();
            quitTable.Quit();
        }
    }
}
