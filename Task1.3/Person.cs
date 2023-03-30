using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    public class Person
    {
        public Person(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public string Name { get; set; }
        public int Year { get; set; }
    }
}
