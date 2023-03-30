using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    public class Months
    {
        public Months(string name, int numberOfMonth, int numberOfDays)
        {
            Name = name;
            NumberOfMonth = numberOfMonth;
            NumberOfDays = numberOfDays;
        }

        public string Name { get; set; }
        public int NumberOfMonth { get; set; }
        public int NumberOfDays { get; set; }
    }
}
