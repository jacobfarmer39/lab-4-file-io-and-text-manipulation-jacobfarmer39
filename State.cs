using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4fileio
{
    class State
    {

        public string Abbreviation { get; set; }
        public string FullName { get; set; }

        public override string ToString()
        {
            return String.Join('|', new string[] { Abbreviation });
        }
    }

}
