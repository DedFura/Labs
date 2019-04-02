using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._4
{
    class Program
    {
        static private int GetReplay(string str1, string str2)
        {
            int count = 0;
            string[] ss = str1.Split(' ');
            foreach (string str in ss)
            {
                if (str == str2)
                {
                    count += 1;
                }
            }
            return (count);
        }
        static void Main(string[] args)
        {
            
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите слово, число повторений которого требуется найти в строке: ");
            string str2 = Console.ReadLine();
           

            Console.WriteLine("Колличество совпадений в тексте = {0}", GetReplay(str1,str2));
            Console.ReadKey();
        }
    }
}
