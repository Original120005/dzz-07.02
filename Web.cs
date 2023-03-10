using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzz_07._02
{
    internal class Web
    {
        private string name;
        private string source;
        private string info;
        private string ip;

        public Web() { }
        public Web(string n, string s, string a, string i)
        {
            name = n;
            source = s;
            info = a;
            ip = i;
        }

        public void Enter()
        {
            Console.Write("Enter name of website: ");
            name = Console.ReadLine();
            Console.Write("Enter source of website: ");
            source = Console.ReadLine();
            Console.Write("Enter something about website: ");
            info = Console.ReadLine();
            Console.Write("Enter ip adress: ");
            ip = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine($"\nWebsite: {name}");
            Console.WriteLine($"Source: {source}");
            Console.WriteLine($"Info: {info}");
            Console.WriteLine($"IP: {ip}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }



    }
}