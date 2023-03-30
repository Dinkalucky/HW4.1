using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._3
{
    internal class Program<T>
    {
        static void Main(string[] args)
        {
            var firstGeneration = new List<Person>
            {
                new Person("Діна",1996),
                new Person("Юлія",1984)
            };

            var secondGeneration = new List<Person>
            {
                new Person("Світлана",1996),
                new Person("Анатолій",1984)
            };

            var grandParentsM = new List<Person>
            {
                new Person("Володимир",1927),
                new Person("Марія",1930)
            };
            var grandParentsP = new List<Person>
            {
                new Person("Мефодій",1927),
                new Person("Марія",1930)
            };
            var familyTree = new List<List<Person>>
            {
                new List<Person> { new Person("Володимир",1927), new Person("Володимир", 1927) }
            };
        }
    }
}
