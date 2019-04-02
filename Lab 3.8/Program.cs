using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "бывальф щшовлопа офзщфва зщ +79994445566 кепощшыкпо +74443332233";
            Regex regex = new Regex(@"\+[0-9]{7,12}");
            MatchCollection mathes = regex.Matches(s);
            if (mathes.Count>0)
            {
                foreach (Match match in mathes)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.ReadKey();
                
        }
    }
}
