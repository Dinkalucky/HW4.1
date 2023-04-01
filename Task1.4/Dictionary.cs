using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._4
{
    public class Dictionary
    {
        public string Ukrainian { get; set; }
        public string Russian { get; set; }
        public string English { get; set; }

        public Dictionary(string ukrainian, string russian, string english)
        {
            Ukrainian = ukrainian;
            Russian = russian;
            English = english;
        }

        public static void SearchingWord(List<Dictionary> dictionary, string word, string translation)
        {
            foreach (var dic in dictionary)
            {
                if (dic.Ukrainian == word)
                {
                    switch (translation)
                    {
                        case "rus":
                            Console.WriteLine($"{dic.Ukrainian} - {dic.Russian}");
                            break;
                        case "eng":
                            Console.WriteLine($"{dic.Ukrainian} - {dic.English}");
                            break;
                    }

                }
            }
        }

        public static void ShowDictionary(List<Dictionary> dictionary)
        {
            Console.WriteLine("\nНаш словник:\n");

            foreach (var dic in dictionary)
            {
                Console.WriteLine($"{dic.Ukrainian} - {dic.Russian} - {dic.English}");
            }
        }
    }
}
