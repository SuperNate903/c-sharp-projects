using System;
using System.Collections.Generic;
using System.Text;

namespace Operators
{
    class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator== (Employee obj1, Employee obj2)
        {
            return obj1.Id == obj2.Id;
        }
        public static bool operator!= (Employee obj1, Employee obj2)
        {
            return obj1.Id != obj2.Id;
        }
    }
}
