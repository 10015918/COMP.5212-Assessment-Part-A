using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Person1
    {
        String fullName;

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String YearOfBirth { get; set; }

        public Person1 (String _FirstName, String _LastName, String _YearOfBirth)
        {
            FirstName = _FirstName;
            LastName = _LastName;
            YearOfBirth = _YearOfBirth;
        }
        public String GetFullName (String FirstName, String LastName, String fullName)
        {
            fullName = FirstName + LastName;
            return fullName;
        }

    }
}
