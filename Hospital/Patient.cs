using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Patient : IAccount
    {
        

        public string Name { get; set; }
        public string Password { get; set; }

        public Patient (string name, string password)
        {
            Name = name;
            Password = password;
        }

        public void GetCalendar()
        {
            Console.WriteLine("Календарь");
        }
    }
}
