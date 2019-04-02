using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "gdfsg rgerg5ewrgwrg6gd sh fgd 10";            
            int prod = Regex.Matches(s, @"\d+").Cast<Match>().Select(m => m.Value).Select(int.Parse).Aggregate(1, (p, v) => p * v);
            Console.WriteLine(prod);
            Console.ReadKey();
        }
    }
}
