using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину слова: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string String = Console.ReadLine();
            string[] words = String.Split(' ', ',', '.', '!', '?', ';');
            var sortWords = from str in words where str.Length == n orderby str select str;
            foreach (var str in sortWords)
                Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
