using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4fileio
{
    class Phone
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string ExchangeCode { get; set; }
        public string LineNumber { get; set; }
        public string FullNumber { get; set; }

        public override string ToString()
        {
            return String.Join('|', new string[] { CountryCode , AreaCode , ExchangeCode, LineNumber , FullNumber });
        }
    }
}
