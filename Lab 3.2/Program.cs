using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = @"Тег <html> является контейнером, который заключает в себе все содержимое веб-страницы, включая теги <form> и <body>. ";

            const string myReg = "<html>";
            MatchCollection myMatch = Regex.Matches(myText, myReg);

            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ", myReg);
            foreach (Match i in myMatch)
                Console.Write("\t" + i.Index);

            // Услажним шаблон регулярного выражения
            // введя в него специальные метасимволы

            const string myReg1 = @"\b[с,д]\S*ериализац\S*";
            MatchCollection match1 = Regex.Matches(myText, myReg1, RegexOptions.IgnoreCase);
            findMyText(myText, match1);

            Console.ReadLine();
        }

        static void findMyText(string text, MatchCollection myMatch)
        {
            Console.WriteLine("\n\nИсходная строка:\n\n{0}\n\n", text);          
        }
    }
}
