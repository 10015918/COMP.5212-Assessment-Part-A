﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Person1
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person1 (string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public string GetFullName ()
        {
            return FirstName + " " + LastName;
        }
        public int GetAge()
        {
            return DateTime.Now.Year - YearOfBirth;
        }

    }
}
