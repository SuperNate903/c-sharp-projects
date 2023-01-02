using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        public static Employee operator== (Employee obj1, Employee obj2)
        {
            if(obj1.FirstName == obj2.FirstName & obj1.LastName == obj2.LastName)
            {
                return obj1;
            }
            else
            {
                return obj2;
            }
        }
        public static Employee operator!= (Employee obj1, Employee obj2)
        {
            if (obj1.FirstName != obj2.FirstName & obj1.LastName != obj2.LastName)
            {
                return obj1;
            }
            else
            {
                return obj2;
            }
        }
    }
}
