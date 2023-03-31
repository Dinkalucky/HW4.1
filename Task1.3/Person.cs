using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
        public List<Person> Children { get; set; } = new List<Person>();

        public void ShowFamily(Person person, string name)
        {
            ShowFamily(person, 0, name);
        }

        private void ShowFamily(Person person, int level, string name)
        {
            foreach (var f in person.Children)
            {
                if (f.Name == name)
                {
                    foreach (var child in f.Children)
                    {
                        ShowFamily(child, level + 1);
                    }
                }
            }
        }

        public void ShowFamily(Person person, int level)
        {
            Console.WriteLine("".PadLeft(level * 4) + (person.Children.Any() ? " + " : " - ") + person.Name + "-" +
                              person.Year);
            foreach (var child in person.Children)
            {
                ShowFamily(child, level + 1);
            }
        }

        public void ShowRelatives(Person person, int year)
        {
            if (person.Year > year)
            {
                Console.WriteLine(person.Name + "-" + person.Year);
            }

            foreach (var f in person.Children)
            {
                ShowRelatives(f, year);
            }
        }

        public void AddChild(Person person, string parentName, string name, int year)
        {
            foreach (var f in person.Children)
            {
                AddChild(f, parentName, name, year);
            }

            if (person.Name == parentName)
            {
                person.Children.Add(new Person(Name = name, Year = year));
            }
        }

        public void RemoveChild(Person person, string name)
        {
            foreach (var f in person.Children)
            {
                if (f.Name == name)
                {
                    person.Children.Remove(f);
                    break;
                }
            }
        }
    }
}
