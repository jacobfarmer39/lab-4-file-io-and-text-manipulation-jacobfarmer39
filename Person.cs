using System;

namespace lab4fileio
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public override string ToString()
        {
            return String.Join('|', new string[] { FirstName , LastName , Address , Phone });
        }
    }
}
