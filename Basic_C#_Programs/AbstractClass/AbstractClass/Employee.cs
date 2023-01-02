using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Employee : Person
    {
        Person person = new Person();
        person.SayName();
    }
}
