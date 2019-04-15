using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IAccount
    {
        int CurrentSum { get; }
        void Put(int sum);
        void Withdraw(int sum);
    }
    interface IClient
    {
        string Name { get; set; }
    }
    class Client : IAccount, IClient
    {
        int _sum;
        public string Name { get; set; }
        public Client(string name, int sum)
        {
            Name = name;
            _sum = sum;
        }
        public int CurrentSum { get { return _sum; } }
        public void Put(int sum) { _sum += sum; }
        public void Withdraw(int sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Client client = new Client("Tom", 200);
            Console.WriteLine(client.CurrentSum);
            client.Put(1000);
            client.Withdraw(500);

            Console.WriteLine(client.CurrentSum); 
            Console.ReadKey();

           
        }
    }
}
