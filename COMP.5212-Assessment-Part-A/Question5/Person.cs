using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
    }
}
