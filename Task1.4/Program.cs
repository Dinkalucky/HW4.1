using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string ukr, rus, eng, word, translation;

            List<Dictionary> dictionary = new List<Dictionary>();
            dictionary.Add(new Dictionary("яблуко", "яблоко", "apple"));
            dictionary.Add(new Dictionary("небо", "небо", "sky"));
            dictionary.Add(new Dictionary("квітка", "цветок", "flower"));
            dictionary.Add(new Dictionary("кіт", "кот", "cat"));
            dictionary.Add(new Dictionary("сонце", "солнце", "sun"));

            Dictionary.ShowDictionary(dictionary);

            Console.WriteLine("Яке слово ви хотіли б додати у словник?");
            ukr = Console.ReadLine();
            Console.WriteLine("Введіть російський переклад");
            rus = Console.ReadLine();
            Console.WriteLine("Введіть англійський переклад");
            eng = Console.ReadLine();

            dictionary.Add(new Dictionary(ukr, rus, eng));

            Dictionary.ShowDictionary(dictionary);

            Console.WriteLine("Яке слово ви шукаєте?");
            word = Console.ReadLine();

            Console.WriteLine("На яку мову перекласти?");
            translation = Console.ReadLine();

            Dictionary.SearchingWord(dictionary,word,translation);

            Console.ReadLine();

        }
    }
}
