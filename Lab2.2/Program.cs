using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Program
    {
        static int SumString(string str)
        {
            string str2 = string.Empty;            
            for (int i = 0; i < str.Length; i++)
                if (!str2.Contains(str[i]))
                {
                    str2 += str[i];
                    
                }
            return (str2.Length);
        }
        static void Main(string[] args)
        {       
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            
            Console.WriteLine("Различных символов = " + SumString(str));
            Console.ReadKey(true);

        }
    }

}
