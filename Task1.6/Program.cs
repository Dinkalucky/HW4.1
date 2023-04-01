using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            NumbersArr numbersArr = new NumbersArr();

            foreach (var num in numbersArr.SqrtNums(intArr))
            {
                Console.Write($"{num} , ");
            }

            Console.ReadLine();
        }
    }
}
