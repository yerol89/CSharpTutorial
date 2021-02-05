using System;
using System.Collections.Generic;
using System.Text;

namespace OOPWithCSharp
{
    //Define a class
    public class Person : Object
    {        
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();
    }
}
