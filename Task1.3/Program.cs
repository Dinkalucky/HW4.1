using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1._3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            var Family = new Person("Дідусь Володимир", 1910)
            {
                Children = new List<Person>()
                {
                    new Person("Тітка Катерина", 1963)
                    {
                        Children = new List<Person>()
                        {
                            new Person("Кузен Сергій", 1980),
                            new Person("Кузен Олександр", 1986)
                            {
                                Children = new List<Person>()
                                {
                                    new Person("Племінник Вячеслав", 2012),
                                    new Person("Племінниця Емілія", 2017),
                                }
                            },
                            new Person("Кузена Маша", 2001),
                        }
                    },
                    new Person("Тітка Наташа", 1967)
                    {
                        Children = new List<Person>()
                        {
                            new Person("Кузена Світлана", 1979),
                            new Person("Кузена Марія", 1986),
                            new Person("Кузен Федір", 1989),
                        }
                    },
                    new Person("Тітка Галя", 1955)
                    {
                        Children = new List<Person>()
                        {
                            new Person("Кузен Олексій", 1980)
                            {
                                Children = new List<Person>()
                                {
                                    new Person("Племінниця Настя", 2003),
                                    new Person("Племінник Семен", 2011),
                                }
                            }
                        }
                    },
                    new Person("Мама", 1960)
                    {
                        Children = new List<Person>()
                        {
                            new Person("Сестра Юля", 1984)
                            {
                                Children = new List<Person>()
                                {
                                    new Person("Племінниця Аріна", 2014),
                                }
                            },
                            new Person ("Діна", 1996)
                        }
                    },
                }
            };

            Console.WriteLine("Введіть ім'я родича, щоб побачити його нащадків");
            string name = Console.ReadLine();

            Family.ShowFamily(Family, name);
            Console.WriteLine("Повне родинне дерево:");
            Family.ShowFamily(Family,0);

            int year;
            Console.WriteLine("Вивести усіх, хто молодше цього року народження");
            Int32.TryParse(Console.ReadLine(), out year);


            Family.ShowRelatives(Family, year);

            Family.AddChild(Family,"Сестра Юля", "Діна2",1995);
            Family.Name = "Дідусь Володимир";
            Family.Year = 1910;
            Console.WriteLine("Повне родинне дерево:");
            Family.ShowFamily(Family, 0);

            
            Family.RemoveChild(Family, "Тітка Катерина");
            Console.WriteLine("Повне родинне дерево:");
            Family.ShowFamily(Family, 0);

            Console.ReadLine();
        }
    }
}
