using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upg._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal efter varandra: ");
            string x = Console.ReadLine();
            int x1 = Convert.ToInt32(x);
            string y = Console.ReadLine();
            int y1 = Convert.ToInt32(y);
            Console.WriteLine("Summan av talen är: " + (x1 + y1));

        }
    }
}
