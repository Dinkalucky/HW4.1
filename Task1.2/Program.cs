using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int number, days;

            var monthsList = new List<Months>
            {
                new Months("Січень", 1, 31),
                new Months("Лютий", 2, 28),
                new Months("Березень", 3, 31),
                new Months("Квітень", 4, 30),
                new Months("Травень", 5, 31),
                new Months("Червень", 6, 30),
                new Months("Липень", 7, 31),
                new Months("Серпень", 8, 31),
                new Months("Вересень", 9, 30),
                new Months("Жовтень", 10, 31),
                new Months("Листопад", 11, 30),
                new Months("Грудень", 12, 31)
            };

            Console.WriteLine("Який місяць вам потрібен?");
            Int32.TryParse(Console.ReadLine(),out number);

            var monthInfo = monthsList.Where(n => n.NumberOfMonth == number).FirstOrDefault();
            Console.WriteLine($"{number} за номером місяць - це {monthInfo.Name}, у ньому {monthInfo.NumberOfDays} днів");

            Console.WriteLine("У якому місяці стільки днів?");
            Int32.TryParse(Console.ReadLine(), out days);
            var daysOfMonth = monthsList.Where(n => n.NumberOfDays == days).ToList();
            Console.Write($"{days} днів у: ");
            foreach(var day in daysOfMonth)
            {
                Console.Write(day.Name+", ");
            }
            Console.ReadKey();
        }


    }
}
