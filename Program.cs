using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzz_07._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Web web = new Web();
            web.Ip = "127.127.127.1";
            web.Print();

            Magazine mag = new Magazine();
            mag.Name = "Best shop";
            mag.Year = "1999";
            mag.Print();

            Shop sh = new Shop();
            sh.Adress = "Neolet pevso";
            sh.Name = "bep";
            sh.Print();
        }
    }
}
