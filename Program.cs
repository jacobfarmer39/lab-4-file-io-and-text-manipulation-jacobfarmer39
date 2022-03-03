using System;
using System.Collections.Generic;
using System.IO;


namespace lab4fileio
{
    class Program
    {
        static char pathSep = Path.DirectorySeparatorChar;
        static void Main(string[] args)
        {
            var cd = Directory.GetCurrentDirectory();
            cd += pathSep + ".." + pathSep + ".." + pathSep + "..";
            Directory.SetCurrentDirectory(cd);
            Console.WriteLine(String.Join("\n", Directory.GetFiles(Directory.GetCurrentDirectory())));

            if (File.Exists("data.csv"))
            {
                var listA = new List<Person>();
                using (var sr = new StreamReader("data.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(",");
                        var FirstName = values[0];
                        var LastName = values[1];
                        var Address = values[3];
                        var Phone = values[8];
                        var p = new Person() { FirstName = FirstName, LastName = LastName, Address = Address, Phone = Phone };
                        ; listA.Add(p);

                    }
                    Console.WriteLine(listA);
                }
                using (StreamWriter sw = new StreamWriter("person.psv"))
                {
                    foreach (Person p in listA)
                    {
                        sw.WriteLine(p);
                    }
                }


            }
            if (File.Exists("data.csv"))
            {
                var listB = new List<Address>();
                using (var sr = new StreamReader("data.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(",");
                        var Number = values[3];
                        var Street = values[3];
                        var City = values[4];
                        var State = values[6];
                        var Zip = values[7];
                        var a = new Address() { Number = Number, Street = Street, City = City, State = State, Zip = Zip };
                        ; listB.Add(a);

                    }
                    Console.WriteLine(listB);
                }
                using (StreamWriter sw = new StreamWriter("address.psv"))
                {
                    foreach (Address a in listB)
                    {
                        sw.WriteLine(a);
                    }
                }


            }
            if (File.Exists("data.csv"))
            {
                var listC = new List<State>();
                using (var sr = new StreamReader("data.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(",");
                        var Abbreviation = values[6];
                        var s = new State() { Abbreviation = Abbreviation };
                        ; listC.Add(s);

                    }
                    Console.WriteLine(listC);
                }
                using (StreamWriter sw = new StreamWriter("state.psv"))
                {
                    foreach (State s in listC)
                    {
                        sw.WriteLine(s);
                    }
                }

                if (File.Exists("data.csv"))
                {
                    var listD = new List<Phone>();
                    using (var sr = new StreamReader("data.csv"))
                    {
                        while (!sr.EndOfStream)
                        {
                            var line = sr.ReadLine();
                            var values = line.Split(",");
                            var indValue = line.Split("-");
                            var CountryCode = "+1";
                            var AreaCode = values[9];
                            var ExchangeCode = values[9];
                            var LineNumber = values[9];
                            var FullNumber = values[9];

                            var ph = new Phone() { CountryCode = CountryCode , AreaCode = AreaCode , ExchangeCode = ExchangeCode, LineNumber = LineNumber , FullNumber = FullNumber };
                            ; listD.Add(ph);

                        }
                        Console.WriteLine(listC);
                    }
                    using (StreamWriter sw = new StreamWriter("phone.psv"))
                    {
                        foreach (Phone ph in listD)
                        {
                            sw.WriteLine(ph);
                        }
                    }

                }
            }
        }
    }
}
