using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Student : Person
    {
        public Student(string _firstName, string _lastName, string _campus) : base(_firstName, _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Campus = _campus;
        }

        public string Campus { get; set; }
        public int StudentID { get; set; }

        public int EnrollStudent()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}
